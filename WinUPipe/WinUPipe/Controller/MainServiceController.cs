using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTech.Properties;

/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UTech.Controller
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author		: 
 * │CreatTime	: 2019/6/20 14:36:37													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © UTech Team 2015-2019. All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */


namespace UTech.Controller
{
    public class MainServiceController
    {


        /// <summary>
        /// 启动主服务
        /// </summary>
        public void Start()
        {
            Logging.Debug($"{Resources.ClientName} Starting...");
        }


        public void Stop()
        {
            Logging.Debug($"{Resources.ClientName} Stop.");
        }
    }
}
