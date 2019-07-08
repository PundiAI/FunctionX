using System;
using Newtonsoft.Json;

namespace Models
{
    public abstract class BaseClass
    {
        #region Protected parameters
        protected string _BaseUrl = "https://open-auth-uat-2.pundix.com/apiPlatformAuth";
        protected string _CallingUrl { get; set; }
        #endregion

        #region Common Properties
        [JsonProperty("appId")]
        public string ApplicationId { get; set; }

        [JsonProperty("timestamp")]
        public int TimeStamp { get; set; }

        [JsonProperty("nonceStr")]
        public string RandomString { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }
        #endregion


        public string FullPath { get; }
        public string RequestMethod { get; set; }

        public abstract override string ToString();

        //public abstract string ToStringForSign();

        public BaseClass(string CallingUrl)
        {
            
            _CallingUrl = CallingUrl;
            FullPath = _BaseUrl + _CallingUrl;
        }
    }
}
