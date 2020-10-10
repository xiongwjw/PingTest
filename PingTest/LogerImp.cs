using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading;
using System.Reflection;
using System.Diagnostics;

namespace PingTest
{
    public class Log
    {
        private static LogerImp logerImp = new LogerImp();

        public enum EnumLogLevel
        {
            Debug = 0,
            Info,
            Error
        }

        private const string DebugName = "[Debug]";
        private const string InfoName = "[Info]";
        private const string ErrorName = "[Error]";

        private static int _loglevel = 0;
        public static EnumLogLevel LogLevel
        {
            set
            {
                _loglevel = (int)value;
            }
        }
        public static string LogPath
        {
            set
            {
                logerImp.LogPath = value;
            }
        }

        public static string Prefix
        {
            set
            {
                logerImp.Prefix = value;
            }
        }

        private static bool _isWriteToConsole = false;
        public static bool IsWriteToConsole
        {
            set
            {
                _isWriteToConsole = value;
            }
        }

        public static bool IsSeperateFolder
        {
            set
            {
                logerImp.IsSeperateFolder = value;
            }
        }

        public static void Debug(string message)
        {
            if (_loglevel < 1)
                LogString(message, DebugName);
        }

        public static void Debug(object obj)
        {
            if (_loglevel < 1)
                LogObject(obj, DebugName);
        }

        public static void Debug(string message, object obj)
        {
            if (_loglevel < 1)
                LogObject(message, obj, DebugName);
        }

        public static void Debug(Exception ex)
        {
            if (_loglevel < 1)
                LogExecption(ex, DebugName);

        }

        public static void Info(string message)
        {
            if (_loglevel < 2)
                LogString(message, InfoName);
        }

        public static void Info(object obj)
        {
            if (_loglevel < 2)
                LogObject(obj, InfoName);
        }

        public static void Info(string message, object obj)
        {
            if (_loglevel < 2)
                LogObject(message, obj, InfoName);
        }

        public static void Info(Exception ex)
        {
            if (_loglevel < 2)
                LogExecption(ex, InfoName);

        }

        public static void Error(string message)
        {
            LogString(message, ErrorName);
        }

        public static void Error(object obj)
        {
                LogObject(obj, ErrorName);
        }

        public static void Error(string message, object obj)
        {
                LogObject(message, obj, ErrorName);
        }

        public static void Error(Exception ex)
        {
                LogExecption(ex, ErrorName);

        }

        private static void LogString(string message,string preName)
        {
            logerImp.Log(preName+ " " + message);
            if (_isWriteToConsole)
                Console.WriteLine(message);
        }

        private static void LogExecption(Exception ex, string preName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ex.Message);
            sb.AppendLine(ex.StackTrace);
            var stacktrace = new StackTrace();
            for (var i = 0; i < stacktrace.FrameCount; i++)
            {
                sb.AppendLine(stacktrace.GetFrame(i).GetFileName() + ":" + stacktrace.GetFrame(i).GetFileLineNumber() + ":" + stacktrace.GetFrame(i).GetMethod());
            }
            logerImp.Log(preName+ " " + sb.ToString());
            if (_isWriteToConsole)
                Console.WriteLine(sb.ToString());
        }

        private static void LogObject(object obj, string preName)
        {
            string msg = ParseObject(obj);
            logerImp.Log(preName+" " + msg);
            if (_isWriteToConsole)
                Console.WriteLine(msg);
        }

        private static void LogObject(string message,object obj, string preName)
        {
            string msg = message + ParseObject(obj);
            logerImp.Log(preName+" " + msg);
            if (_isWriteToConsole)
                Console.WriteLine(msg);
        }

        private static string ParseObject(object obj)
        {
            if (obj is string)
                return obj.ToString();
            else
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendLine();
                foreach (PropertyInfo p in obj.GetType().GetProperties())
                {
                    msg.AppendFormat("{0} : {1}", p.Name, p.GetValue(obj,null)?.ToString());
                    msg.AppendLine();
                }
                return msg.ToString();
            }
        }

        private class LogerImp
        {
            public LogerImp()
            {
                IsSeperateFolder = false;
                Prefix = string.Empty;
                isRuning = true;
                ThreadPool.QueueUserWorkItem(WriteFile, s1.Token);
            }

            ~LogerImp()
            {
                if (logMessageQueue.Count > 0)// if still waiting write , give more 3 second to write
                {
                    queueEvent.Set();
                    Thread.Sleep(3000);
                }
                isRuning = false;
                s1.Cancel();
            }

            private bool isRuning = false;
            private CancellationTokenSource s1 = new CancellationTokenSource();

            private Queue<string> logMessageQueue = new Queue<string>();
            private AutoResetEvent queueEvent = new AutoResetEvent(false);

            private string _logPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            public string LogPath
            {
                get
                {
                    return _logPath;
                }
                set
                {
                    try
                    {
                        if (!Directory.Exists(value))
                            Directory.CreateDirectory(value);
                        _logPath = value;
                    }
                    catch { }
                }
            }
            public bool IsSeperateFolder { get; set; }
            public string Prefix { get; set; }

            public void Log(string message)
            {
                if (message.Length > 500)
                    message = message.Substring(500) + "...";

                if (logMessageQueue.Count == 1999)
                    AddLogToQueue("messsage queue reach 2000,discard message");

                if (message != string.Empty && logMessageQueue.Count < 2000)
                {
                    AddLogToQueue(message);
                }
            }

            private void AddLogToQueue(string message)
            {
                logMessageQueue.Enqueue(message);
                queueEvent.Set();
            }

            private void WriteFile(object state)
            {
                StreamWriter sw = null;
                FileStream fs = null;
                try
                {
                    string message = string.Empty;
                    string fileName = string.Empty;

                    while (isRuning)
                    {
                        queueEvent.WaitOne();
                        while (logMessageQueue.Count > 0 && isRuning)// write all one time
                        {
                            message = logMessageQueue.Dequeue();
                            string folder_name = LogPath;
                            if (IsSeperateFolder)
                                folder_name = Path.Combine(LogPath, DateTime.Now.Year.ToString(), DateTime.Now.ToString("MM"));
                            string file_name = Path.Combine(folder_name, DateTime.Today.ToString("yyyyMMdd") + ".txt");
                            if (Prefix != string.Empty)
                                file_name = Path.Combine(folder_name, Prefix + DateTime.Today.ToString("yyyyMMdd") + ".txt");
                            if (!file_name.Equals(fileName) || fs == null || sw == null)// if we change to another file . renew the file and folder
                            {
                                fileName = file_name;
                                if (!Directory.Exists(folder_name))
                                    Directory.CreateDirectory(folder_name);
                                if (fs != null) fs.Close();
                                if (sw != null) sw.Close();
                                fs = new FileStream(fileName, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                                sw = new StreamWriter(fs, Encoding.UTF8);
                            }
                            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + " : " + message);
                        }
                        sw.Flush();
                    }
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
                catch { }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }

        }

    }

}
