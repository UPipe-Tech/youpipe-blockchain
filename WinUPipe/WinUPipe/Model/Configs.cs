using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: UTech.Model
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author		: 
 * │CreatTime	: 2019/6/25 10:03:06													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © UTech Team 2015-2019. All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */


namespace UTech.Model
{
    public class Configuration
    {
        private ProfileKey _key = null;
        /// <summary>
        /// 
        /// </summary>
        public ProfileKey Key { get { return _key; } }

        public bool Enable { get; set; } = false;

        public ProxyMode ProxyMode { get; set; } = ProxyMode.Auto;
        /// <summary>
        /// 
        /// </summary>
        public Configuration()
        {
            loadKey();
            loadConfig();
        }


        public void initKey(ProfileKey key)
        {
            this._key = key;
        }
        /// <summary>
        /// 检查是否存在Key ，同 dll
        /// </summary>
        private void loadKey()
        {
            
        }

        /// <summary>
        /// 加载需要记住的配置，如开启状态
        /// </summary>
        private void loadConfig()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool IsNoneAccount()
        {
            return _key == null;
        }
    }

    public class ProfileKey
    {
        public string hashKey;
        public string secretKey;

        public ProfileKey(string hash,string secret)
        {
            this.hashKey = hash;
            this.secretKey = secret;
        }
    }
}
