using Jamesnet.Wpf.Controls;
using NewToys.Logger;
using NewToys.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace NewToys
{
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            Dispatcher.UnhandledExceptionFilter += Dispatcher_UnhandledExceptionFilter;
            Dispatcher.UnhandledException += Dispatcher_UnhandledException;

            return new MainView();
        }

        private void Dispatcher_UnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            ManagementLogger.Singleton.Write(e.Exception.Message, ManagementLogger.LogType.Fetal);
            ManagementLogger.Singleton.Write(e.Exception.StackTrace, ManagementLogger.LogType.Fetal);
            throw new NotImplementedException();
        }

        private void Dispatcher_UnhandledExceptionFilter(object sender, DispatcherUnhandledExceptionFilterEventArgs e)
        {
            // true를 설정하면 응용 프로그램이 비정상 종료되지 않으나 false를 설정하면 응용 프로그램이 비정상 종료된다.
            e.RequestCatch = true;
        }
    }
}
