using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTech.Controller;
using UTech.Properties;
using UTech.Util;
using UTech.View;

namespace WinUPipe
{
    static class Program
    {
        public static MainServiceController MainController { get; private set; }
        public static MenuViewController MenuController { get; private set; }

        public static string[] Args { get; private set; }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Args = args;
            string title = Resources.ClientName + " Error";
            if (!Utils.IsWinVistaOrHigher())
            {
                MessageBox.Show(I18N.GetString("Unsupported operating system, use Windows Vista at least."),
                    title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Utils.IsSupportedRuntimeVersion())
            {
                MessageBox.Show(I18N.GetString("Unsupported .NET Framework, please update to 4.6.2 or later."),
                    title, MessageBoxButtons.OK, MessageBoxIcon.Error);

                Process.Start(
                    "https://www.microsoft.com/download/details.aspx?id=53344");
                return;
            }
            // Release Memory
            Utils.ReleaseMemory(true);

            using(Mutex mutex = new Mutex(false,
                $"Global\\{Resources.ClientName}_{Application.StartupPath.GetHashCode()}"))
            {
                //
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                //UI Exception
                Application.ThreadException += Application_ThreadException;

                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!mutex.WaitOne(0, false))
                {
                    Process[] oldProcesses = Process.GetProcessesByName($"{Resources.ClientName}");
                    if(oldProcesses.Length > 0)
                    {
                        Process oldProcess = oldProcesses[0];
                    }
                    MessageBox.Show(
                        I18N.GetString("Find {0} icon in your notify tray",Resources.ClientName)+
                        Environment.NewLine +
                        I18N.GetString("If you want to start multiple {0},make a copy in another directory.",Resources.ClientName)+
                        I18N.GetString("{0} is already running.", Resources.ClientName)
                        );
                    return;
                }

            }

            Directory.SetCurrentDirectory(Application.StartupPath);

#if DEBUG
            Logging.OpenLogFile();

            //truncate privoxy log file while debugging
            string privoxyLogFileName = Utils.GetTempPath("privoxy.log");
            if(File.Exists(privoxyLogFileName))
                using(new FileStream(privoxyLogFileName, FileMode.Truncate))
                {

                }
#else
            Logging.OpenLogFile();
#endif


            MainController = new MainServiceController();
            MenuController = new MenuViewController(MainController);
            MainController.Start();
            Application.Run();
        }



#region Event Handler
        private static int exited = 0;
        /// <summary>
        /// UI 端处理异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender,ThreadExceptionEventArgs e)
        {
            if(Interlocked.Increment(ref exited) == 1)
            {
                string errorMsg = $"Exception Detail:{Environment.NewLine}{e.Exception}";
                Logging.Error(e.Exception);
                MessageBox.Show(
                    $"{I18N.GetString("Unexpected error, Client will exit. Please report to")} {Resources.IssueURL} {Environment.NewLine}{errorMsg}",
                    $"{Resources.ClientName} UI Error",MessageBoxButtons.OK,MessageBoxIcon.Error
                    );

                Application.Exit();
            }
        }
        /// <summary>
        /// 后台异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender,UnhandledExceptionEventArgs e)
        {
            if(Interlocked.Increment(ref exited) == 1)
            {
                string errMsg = e.ExceptionObject.ToString();
                Logging.Error(errMsg);
                MessageBox.Show($"{I18N.GetString("Unexpected error, Brokk will exit. Please report to")} {Resources.IssueURL} {Environment.NewLine}{errMsg}",
                    $"{Resources.ClientName} non-UI Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Application.Exit();
            }
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ApplicationExit(object sender,EventArgs e)
        {
            // detach static event handlers
            Application.ApplicationExit -= Application_ApplicationExit;
            Application.ThreadException -= Application_ThreadException;

            if(MainController != null)
            {
                MainController.Stop();
                MainController = null;
            }

            //TODO Ohter Instance Or Object Destory

        }

#endregion
    }
}
