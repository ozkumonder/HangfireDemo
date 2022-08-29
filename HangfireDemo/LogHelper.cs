using System.Diagnostics;
using System.Reflection;

namespace HangfireDemo
{
    public static class LogHelper
    {
        public static void Log(string logMessage)
        {
            try
            {
                string logLevelDefinition = string.Empty;

                if (string.IsNullOrEmpty(logMessage)) return;
                string directoryName = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                directoryName = string.Concat(directoryName, "\\Logs");
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
                DateTime now = DateTime.Now;
                string str = string.Concat(directoryName, "\\Log_", now.ToString("dd-MM-yyyy"), ".txt");
                using (var streamWriter = new StreamWriter(str, true))
                {
                    streamWriter.WriteLine(string.Concat(DateTime.Now, logLevelDefinition, " ", string.Concat("<!--------------- ", logMessage, " ---------------!>")));
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
            catch (Exception exception)
            {
                EventLog.WriteEntry(nameof(LogHelper), exception.Message, EventLogEntryType.Error);
            }
        }
        public static void Log(LogLevel logLevel, string logMessage)
        {
            try
            {
                string logLevelDefinition = string.Empty;
                switch (logLevel)
                {
                    case LogLevel.Application:
                        logLevelDefinition = "[Application]";
                        break;
                    case LogLevel.Error:
                        logLevelDefinition = "[ERROR]:";
                        break;
                    case LogLevel.Warning:
                        logLevelDefinition = "[WARN]:";
                        break;
                    case LogLevel.Info:
                        logLevelDefinition = "[INFO]:";
                        break;
                    case LogLevel.Question:
                        logLevelDefinition = "[INFO]:";
                        break;
                }
                if (string.IsNullOrEmpty(logMessage)) return;
                string directoryName = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                directoryName = string.Concat(directoryName, "\\Logs");
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
                DateTime now = DateTime.Now;
                string str = string.Concat(directoryName, "\\Log_", now.ToString("dd-MM-yyyy"), ".txt");
                using (var streamWriter = new StreamWriter(str, true))
                {
                    streamWriter.WriteLine(string.Concat(DateTime.Now, logLevelDefinition, " ", logMessage));
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
            catch (Exception exception)
            {
                EventLog.WriteEntry(nameof(LogHelper), exception.Message, EventLogEntryType.Error);
            }
        }
        public static void Log(LogLevel logLevel, Type currentClass, MethodBase currentMethod, string logMessage)
        {
            try
            {
                string logLevelDefinition = string.Empty;
                switch (logLevel)
                {
                    case LogLevel.Application:
                        logLevelDefinition = "[Application]";
                        break;
                    case LogLevel.Error:
                        logLevelDefinition = "[ERROR]:";
                        break;
                    case LogLevel.Warning:
                        logLevelDefinition = "[WARN]:";
                        break;
                    case LogLevel.Info:
                        logLevelDefinition = "[INFO]:";
                        break;
                    case LogLevel.Question:
                        logLevelDefinition = "[INFO]:";
                        break;
                }
                if (string.IsNullOrEmpty(logMessage)) return;
                string directoryName = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                directoryName = string.Concat(directoryName, "\\Logs");
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
                DateTime now = DateTime.Now;
                string str = string.Concat(directoryName, "\\Log_", now.ToString("dd-MM-yyyy"), ".txt");
                using (var streamWriter = new StreamWriter(str, true))
                {
                    streamWriter.WriteLine(string.Concat(DateTime.Now, logLevelDefinition, " ", currentClass?.Name, " ", currentMethod?.Name, " ", logMessage));
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
            catch (Exception exception)
            {
                EventLog.WriteEntry(nameof(LogHelper), exception.Message, EventLogEntryType.Error);
            }

        }
    }
    public enum LogLevel
    {
        Application,
        Error,
        Warning,
        Info,
        Question
    }
}
