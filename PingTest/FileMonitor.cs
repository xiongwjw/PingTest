using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//using Common;

namespace PingTest
{
    public abstract class FileMonitor : IFileMonitor, IDisposable
    {
        private const int DefaultBufferSize = 1048576;
        private readonly static object _syncRoot = new object();
        private bool _bufferedRead = false;
        private Encoding _encoding;
        private bool _fileExists;
        protected string _filePath;
        private bool _isDisposed;
        private int _readBufferSize = DefaultBufferSize;
        private Stream _stream;
        private StreamReader _streamReader;



        public Encoding GetEncoding()
        {
            return _encoding;
        }

        protected FileMonitor(string filePath, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;

            Preconditions.CheckNotEmptyOrNull(filePath, "filePath");

            _filePath = filePath;
            _encoding = encoding;

        }

        public void OpenFile()
        {
            _fileExists = GetFileExists();

            if (_fileExists)
            {
                OpenFile(_filePath);
            }
        }

        public void ClearLog()
        {
            try
            {
                StreamWriter sw = new StreamWriter(_filePath);
                sw.Write(string.Empty);
                sw.Flush();
                sw.Close();
                sw.Dispose();
                _stream.Close();
                _stream.Dispose();
                _streamReader.Close();
                _streamReader.Dispose();
                OpenFile(_filePath);
            }
            catch (System.Exception ex)
            {
                Log.Info(ex.Message);
            }
            
        }

        public void SaveLog(string text)
        {
            try
            {
                StreamWriter sw = new StreamWriter(_filePath);
                sw.Write(text);
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
            catch (System.Exception ex)
            {
                Log.Info(ex.Message);
            }
        }

        #region IFileMonitor Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public event Action<IFileMonitor, string> FileUpdated;
        public event Action<string> FileOpened;


        public string FilePath
        {
            get { return _filePath; }
        }

        public int ReadBufferSize
        {
            get { return _readBufferSize; }
            set
            {
                // Buffer cannot be 0 or negative
                Preconditions.CheckArgumentRange("value", value, 1, int.MaxValue);
                _readBufferSize = value;
            }
        }


        public void RefreshAsync()
        {
            ThreadPool.QueueUserWorkItem(CheckForChanges);
            //return Task.Run(() => CheckForChanges());
        }

        public void UpdateEncoding(Encoding encoding)
        {
            lock (_syncRoot)
            {
                _encoding = encoding;
                OpenFile(_filePath);
            }
        }

        public bool BufferedRead
        {
            get { return _bufferedRead; }
            set { _bufferedRead = value; }
        }

        #endregion

        private void OpenFile(string filePath)
        {
            // Dispose existing stream
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                return;
            }
            try
            {
                lock (_syncRoot)
                {
                    DisposeStream();

                    // File is opened for read only, and shared for read, write and delete
                    _stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                    _streamReader = new StreamReader(_stream, _encoding);

                    //first update 
                    string content = _streamReader.ReadToEnd();
                    // OnFileUpdated(content);
                    if (FileOpened != null)
                        FileOpened(content);
                    // Start at the end of the file

                    _streamReader.BaseStream.Seek(0, SeekOrigin.End);
                }
            }
            catch (System.Exception ex)
            {
                Log.Info(ex.Message);
            }
           
          
        }

      

        protected virtual void OnFileUpdated(string updatedContent)
        {
            var handler = FileUpdated;

            if (handler != null)
            {
                handler(this, updatedContent);
            }
        }


        private bool GetFileExists()
        {
            return File.Exists(_filePath);
        }

        protected virtual void CheckForChanges(object state)
        {
            try
            {
                lock (_syncRoot)
                {
                  

                    if (_streamReader == null)
                    {
                        // File is not open
                        return;
                    }

                    var baseStream = _streamReader.BaseStream;

                    if (baseStream.Position > baseStream.Length)
                    {
                        // File is smaller than the current position
                        // Seek to the end
                        baseStream.Seek(0, SeekOrigin.End);
                    }

                    if (_streamReader.EndOfStream)
                        return;

                    if (BufferedRead)
                    {
                        var buffer = new char[ReadBufferSize];
                        int charCount;

                        while ((charCount = _streamReader.Read(buffer, 0, ReadBufferSize)) > 0)
                        {
                            var appendedContent = new string(buffer, 0, charCount);

                            if (!string.IsNullOrEmpty(appendedContent))
                            {
                                OnFileUpdated(appendedContent);
                            }
                        }
                    }
                    else
                    {
                        var appendedContent = _streamReader.ReadToEnd();

                        if (!string.IsNullOrEmpty(appendedContent))
                        {
                            OnFileUpdated(appendedContent);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                Log.Info(ex.Message);
            }
            
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed)
            {
                return;
            }

            if (disposing)
            {
                DisposeStream();
            }

            _isDisposed = true;
        }

        private void DisposeStream()
        {
            if (_streamReader != null)
            {
                _streamReader.Dispose();
            }

            if (_stream != null)
            {
                _stream.Dispose();
            }
        }

        ~FileMonitor()
        {
            Dispose(false);
        }
    }
}