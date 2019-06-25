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

    }

    public struct ProfileKey
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
