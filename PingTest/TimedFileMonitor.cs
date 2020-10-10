using System;
using System.IO;
using System.Text;
using System.Timers;

namespace PingTest
{
    public class TimedFileMonitor : FileMonitor, IDisposable
    {
        private readonly Timer _timer;
        private readonly FileSystemWatcher _watcher;

        public bool StopListening { get; set; }

        public TimedFileMonitor(string filePath, Encoding encoding = null)
            : base(filePath, encoding)
        {
            this._timer = new Timer(2000);
            this._timer.Elapsed += TimerCallback;
            this._timer.Start();

            _watcher = CreateFileWatcher(filePath);
        }

        private FileSystemWatcher CreateFileWatcher(string filePath)
        {
            var watcher = new FileSystemWatcher(Path.GetDirectoryName(filePath), Path.GetFileName(filePath));

            watcher.Changed += WatcherOnChanged;
            watcher.NotifyFilter = NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.Size;
            watcher.EnableRaisingEvents = true;

            return watcher;
        }

        private void WatcherOnChanged(object sender, FileSystemEventArgs fileSystemEventArgs)
        {
            if (!StopListening)
                CheckForChanges(null);
        }

        private void TimerCallback(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (!StopListening)
                CheckForChanges(null);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_timer != null)
                {
                    _timer.Dispose();
                }

                if (_watcher != null)
                {
                    _watcher.Dispose();
                }
            }

            base.Dispose(disposing);
        }
    }
}