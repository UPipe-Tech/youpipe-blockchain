using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTech.Controller;

/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UTech.Util
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author		: 
 * │CreatTime	: 2019/6/25 10:07:31													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © UTech Team 2015-2019. All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */


namespace UTech.Util
{
    #region Utils Begin

    /// <summary>
    /// 工具类
    /// </summary>
    public static class Utils
    {
        private static string _tempPath = null;


        public static string GetTempPath()
        {
            try
            {
                if (_tempPath == null)
                {
                    _tempPath = Directory.CreateDirectory(Path.Combine(Application.StartupPath, "utech_temp")).FullName;
                }
            }catch(Exception e)
            {
                Logging.Error(e);
                throw;
            }

            return _tempPath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string GetTempPath(string filename)
        {
            return Path.Combine(GetTempPath(), filename);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetStartPath()
        {
            return Path.Combine(Application.StartupPath);
        }


        public static void ReleaseMemory(bool removePage)
        {
            // release any unused pages
            // making the numbers look good in task manager
            // this is totally nonsense in programming
            // but good for those users who care
            // making them happier with their everyday life
            // which is part of user experience
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();

            if (removePage)
            {
                // as some users have pointed out
                // removing pages from working set will cause some IO
                // which lowered user experience for another group of users
                //
                // so we do 2 more things here to satisfy them:
                // 1. only remove pages once when configuration is changed
                // 2. add more comments here to tell users that calling
                //    this function will not be more frequent than
                //    IM apps writing chat logs, or web browsers writing cache files
                //    if they're so concerned about their disk, they should
                //    uninstall all IM apps and web browsers
                //
                // please open an issue if you're worried about anything else in your computer
                // no matter it's GPU performance, monitor contrast, audio fidelity
                // or anything else in the task manager
                // we'll do as much as we can to help you
                //
                // just kidding
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
            }
        }

        #region System Util

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// 注册表
        /// </summary>
        /// <param name="name"></param>
        /// <param name="writeable"></param>
        /// <param name="hive"></param>
        /// <returns></returns>
        public static RegistryKey OpenRegistryKey(string name,
            bool writeable,RegistryHive hive = RegistryHive.CurrentUser)
        {
            // we are building x86 binary for both x86 and x64, which will
            // cause problem when opening registry key
            // detect operating system instead of CPU
            if (name.IsNullOrEmpty()) throw new ArgumentException(nameof(name));

            try
            {
                RegistryKey userKey = RegistryKey.OpenBaseKey(hive,
                    Environment.Is64BitOperatingSystem ?
                    RegistryView.Registry64 : RegistryView.Registry32)
                    .OpenSubKey(name, writeable);
                return userKey;
            }catch(ArgumentException agrEx)
            {
                MessageBox.Show("OpenRegistryKey:" + agrEx.ToString());
                return null;
            }
            catch(Exception ex)
            {
                Logging.LogUsefukException(ex);
                return null;
            }
        }

        /// <summary>
        /// 是否Vista 
        /// </summary>
        /// <returns></returns>
        public static bool IsWinVistaOrHigher()
        {
            return Environment.OSVersion.Version.Major > 5;
        }

        public static bool Is64BitOperatingSystem()
        {
            return Environment.Is64BitOperatingSystem;
        }
        /// <summary>
        /// 检验当前系统环境是否支持
        /// </summary>
        /// <returns></returns>
        public static bool IsSupportedRuntimeVersion()
        {
            /*
             * +-----------------------------------------------------------------+----------------------------+
             * | Version                                                         | Value of the Release DWORD |
             * +-----------------------------------------------------------------+----------------------------+
             * | .NET Framework 4.6.2 installed on Windows 10 Anniversary Update | 394802                     |
             * | .NET Framework 4.6.2 installed on all other Windows OS versions | 394806                     |
             * +-----------------------------------------------------------------+----------------------------+
             */
            const int minSupportedRelease = 394802;
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";
            using(var ndpKey = OpenRegistryKey(subkey, false, RegistryHive.LocalMachine))
            {
                if(ndpKey?.GetValue("Release") != null)
                {
                    var releaseKey = (int)ndpKey.GetValue("Release");
                    if (releaseKey >= minSupportedRelease)
                        return true;
                }
            }
            return false;

        }
        #endregion

        #region kernel32 DLL
        /// <summary>
        /// DLLImport会按照顺序去查找DLL文件(程序当前目录>System32目录>环境变量Path所设置路径)
        /// 返回类型变量、方法名称、参数列表一定要与DLL文件中的定义相一致。
        /// 调用系统核心 DLL
        /// </summary>
        /// <param name="process"></param>
        /// <param name="minimumWorkingSetSize"></param>
        /// <param name="maximumWorkingSetSize"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        [return:MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetProcessWorkingSetSize(IntPtr process,
            UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);
        #endregion
    }

    #endregion


    #region ViewUtils
    public static class ViewUtils
    {
        public static IEnumerable<TControl> GetChildControls<TControl>(this Control control) where TControl : Control
        {
            if(control.Controls.Count == 0)
            {
                return Enumerable.Empty<TControl>();
            }

            var children = control.Controls.OfType<TControl>().ToList();

            return children.SelectMany(GetChildControls<TControl>).Concat(children);
        }

        public static void SetNotifyIconTray(NotifyIcon icon,string text)
        {
            if (text.Length >= 128)
                throw new ArgumentOutOfRangeException("Text limited to 127 characters.");
            Type t = typeof(NotifyIcon);
            BindingFlags hidden = BindingFlags.NonPublic | BindingFlags.Instance;

            t.GetField("text", hidden).SetValue(icon, text);

            if ((bool)t.GetField("added", hidden).GetValue(icon))
                t.GetMethod("UpdateIcon", hidden).Invoke(icon, new object[] { true });
        }
    }
    #endregion
}
