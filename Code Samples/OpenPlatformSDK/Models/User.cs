using System;
using Newtonsoft.Json;

namespace Models
{
    public class User : BaseClass
    {
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        public User() : base("/api/v1/user")
        {
            RequestMethod = "GET";
        }

        public override string ToString()
        {
            string format = "appId={0}&nonceStr={1}&timestamp={2}&accessToken={3}";
            string res = string.Format(format, this.ApplicationId, this.RandomString, this.TimeStamp, this.AccessToken);
            if (!string.IsNullOrEmpty(this.Sign))
            {
                res = string.Format("{0}&sign={1}", res, this.Sign);
            }
            
            return res;
        }
    }
}
