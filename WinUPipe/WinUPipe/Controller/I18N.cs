using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;



/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UTech.Controller
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author		: 
 * │CreatTime	: 2019/6/20 11:12:32													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © UTech Team 2015-2019. All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */


namespace UTech.Controller
{
    
    using UTech.Properties;
    /// <summary>
    /// 處理國際化
    /// </summary>
    public static class I18N
    {
        private static Dictionary<string, string> _strs = new Dictionary<string, string>();

        /// <summary>
        /// 解析i18n國際化文件
        /// </summary>
        /// <param name="res"></param>
        private static void  Initial(string res)
        {
            using(var sr = new StringReader(res))
            {
                foreach(var line in sr.NonWhiteSpaceLines())
                {
                    if (line[0] == '#')
                        continue;

                    var pos = line.IndexOf('=');
                    if (pos < 1)
                        continue;
                    _strs[line.Substring(0, pos)] = line.Substring(pos + 1);
                }
            }

        }


        static I18N()
        {           
            //
            string local = CultureInfo.CurrentCulture.EnglishName;
            if (local.StartsWith("Chinese", StringComparison.OrdinalIgnoreCase))
            {
                Initial(local.Contains("Traditional") ? Resources.zh_TW : Resources.zh_CN);
            }else if (local.StartsWith("Japanese", StringComparison.OrdinalIgnoreCase))
            {
                Initial(Resources.fa_IR);
            }
        }

        /// <summary>
        /// 獲取I18n,替換 {}
        /// </summary>
        /// <param name="key"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public static string GetString(string key,params object[] args)
        {
            return _strs.ContainsKey(key) ? 
                string.Format(_strs[key], args) : string.Format(key, args);
        }
    }
}
