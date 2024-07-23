using System.Diagnostics;
using System.Reflection;
using Serilog;
using Serilog.Templates;

namespace NewToys.Logger
{
    public class ActiveLogger
    {
        #region Singleton
        public static ActiveLogger Singleton { get; private set; }

        static ActiveLogger()
        {
            Singleton = new ActiveLogger();
        }
        private ActiveLogger() { }
        #endregion

        public void Write(string message, string instanceName = "")
        {
            using (var log = new LoggerConfiguration()
               .MinimumLevel.Information()
               .WriteTo.File
               (
                new ExpressionTemplate("[{@t:yyyy-MM-dd HH:mm:ss}] [{@l:u3}] {#if SourceContext is not null} [{SourceContext}] {#end} {@m}\n{@x}"),
                AppDomain.CurrentDomain.BaseDirectory + @"ActiveLog\ActiveLog.txt",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 62 //Log 폴더 안의 최대 파일 개수.
               )
               .CreateLogger())
            {
                StackTrace stackTrace = new StackTrace();
                StackFrame stackFrame = stackTrace.GetFrame(1);
                MethodBase methodBase = stackFrame.GetMethod();

                if (string.IsNullOrEmpty(instanceName))
                    log.Information($"[{methodBase.DeclaringType.Name}.{methodBase.Name}] {message} ");
                else
                    log.Information($"[{instanceName}] {message} ");
            }
        }
    }

    public class ManagementLogger
    {
        public enum LogType { Warning, Error, Fetal }

        #region Singleton
        public static ManagementLogger Singleton { get; private set; }

        static ManagementLogger()
        {
            Singleton = new ManagementLogger();
        }
        private ManagementLogger() { }
        #endregion

        public void Write(string? message, LogType logType, string instanceName = "", Exception? exception = null)
        {
            using var log = new LoggerConfiguration()
               .MinimumLevel.Warning()
               .WriteTo.File
               (
                new ExpressionTemplate("[{@t:yyyy-MM-dd HH:mm:ss}] [{@l:u3}] {#if SourceContext is not null} [{SourceContext}] {#end} {@m}\n{@x}"),
                AppDomain.CurrentDomain.BaseDirectory + @"ManagementLog\ManagementLog.txt",
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 62 //Log 폴더 안의 최대 파일 개수.
               )
               .CreateLogger();
            StackTrace stackTrace = new();
            StackFrame? stackFrame = stackTrace.GetFrame(1);
            MethodBase? methodBase = stackFrame.GetMethod();

            if (string.IsNullOrEmpty(instanceName))
            {
                switch (logType)
                {
                    case LogType.Warning:
                        log.Warning($"[{instanceName}.{methodBase.Name}] {message} ", exception);
                        break;
                    case LogType.Error:
                        log.Error($"[{instanceName}.{methodBase.Name}] {message} ", exception);
                        break;
                    case LogType.Fetal:
                        log.Fatal($"[{instanceName}.{methodBase.Name}] {message} ", exception);
                        break;

                }
            }
            else
            {
                switch (logType)
                {
                    case LogType.Warning:
                        log.Warning($"[{methodBase.DeclaringType.Name}.{methodBase.Name}] {message} ", exception);
                        break;
                    case LogType.Error:
                        log.Error($"[{methodBase.DeclaringType.Name}.{methodBase.Name}] {message} ", exception);
                        break;
                    case LogType.Fetal:
                        log.Fatal($"[{methodBase.DeclaringType.Name}.{methodBase.Name}] {message} ", exception);
                        break;

                }
            }
        }
    }
}
