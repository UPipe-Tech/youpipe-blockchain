using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTech.Model;
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
    public sealed class MainServiceController
    {
        //UI 内存中配置信息
        private Configuration _config;

        #region EventHandler
        public event EventHandler EnableStatusChanged;
        public event EventHandler GlobalStatusChanged;
        #endregion


        #region Singleton
        /// <summary>
        /// 
        /// </summary>
        public static MainServiceController Instance
        {
            get { return Nested.instance; }
        }

        /// <summary>
        /// 
        /// </summary>
        private class Nested
        {
            static Nested(){}

            internal static readonly MainServiceController instance = new MainServiceController();
        }

        private MainServiceController()
        {
            _config = new Configuration();
            
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="enabled"></param>
        public void ToggleEnable(bool enabled)
        {
            this._config.Enable = enabled;
            //TODO 

            if(EnableStatusChanged != null)
            {
                EnableStatusChanged(this, new EventArgs());
            }
        }

        public void ToggleGlobalStatus(ProxyMode mode)
        {
            this._config.ProxyMode = mode;

            if (GlobalStatusChanged != null)
            {
                GlobalStatusChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Configuration GetCurrentConfiguration()
        {
            return this._config;
        }

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
