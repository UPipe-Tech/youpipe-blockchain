using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTech.Controller;
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

            using(Mutex mutex = new Mutex(false,$"Global\\youPipeBc_{Application.StartupPath.GetHashCode()}"))
            {


            }

            MainController = new MainServiceController();
            MenuController = new MenuViewController(MainController);
            Application.EnableVisualStyles();
            Application.Run(new CreateAccountForm());
        }
    }
}
