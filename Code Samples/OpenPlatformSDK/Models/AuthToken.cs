using System;
using Newtonsoft.Json;

namespace Models
{
    public class AuthToken : BaseClass
    {
        public string BaseUrlString { get { return _BaseUrl; } }

        [JsonProperty("authToken")]
        public string Token { get; set; }

        public AuthToken() : base("/api/v1/auth/token")
        {
            RequestMethod = "GET";
        }

    

        public override string ToString()
        {
            string res = string.Format("appId={0}&nonceStr={2}&timestamp={1}", this.ApplicationId, this.TimeStamp.ToString(), this.RandomString);

            if (!string.IsNullOrEmpty(this.Sign))
            {
                res = string.Format("{0}&sign={1}",res, this.Sign);
            }
            return res;
        }

        /*public override string ToStringForSign()
        {
            string res = string.Format("appId={0}&nonceStr={2}", this.ApplicationId, this.TimeStamp.ToString(), this.RandomString);
            return res;
        }*/
    }
}
