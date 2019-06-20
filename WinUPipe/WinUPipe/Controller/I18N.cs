using System;
using System.Collections.Generic;
using System.IO;



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


        private static void  Initial(string res)
        {
            using(var sr = new StringReader(res))
            {
                foreach(var line in sr.NonWhiteSpaceLines())
                {

                }
            }

        }
    }
}
