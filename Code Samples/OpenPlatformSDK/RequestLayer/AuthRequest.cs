using System;
using System.Threading.Tasks;
using HttpRequest;
using Models;
using Newtonsoft.Json;

namespace RequestLayer
{
    public class AuthRequest
    {
        public AuthRequest()
        {
        }

        public static AuthResponse GetAuthResponse()
        {
            AuthToken authToken = new AuthToken();
            authToken.ApplicationId = "201906191606516214096";


            //var timeSpan = TimeSpan.FromSeconds(unixDateTime);


            authToken.TimeStamp = Common.GetCurrentTimestamp();
            authToken.RandomString = "demoStr1561629575";//Guid.NewGuid().ToString("N");
            string tmpSign = Common.AddSecretKey(authToken.ToString());
            authToken.Sign = Common.ComputeSha256Hash(tmpSign);



            MyHttpRequest request = new MyHttpRequest();
            var res = request.PostData(authToken.FullPath + "?" + authToken.ToString(), null, authToken.RequestMethod);
            //var res = request.PostData(authToken.BaseUrlString + "/api/v1/support/initParams", "appId=" + authToken.ApplicationId, "POST");

            //string res = "{\"code\": 200,\"msg\": \"success\",\"data\": {\"init\": {\"appId\": \"20190529140513127573440\", \"sign\": \"807c7db8aeb64cef47fcc62925df65b3d9b91c625559d82822fc5df48018bd32\",\"nonceStr\":\"demoStr1561621960\",\"timestamp\":\"1561621960\"}}}";

            //string res = "{\"code\": 200,\"msg\": \"success\",\"data\": { \"init\":{ \"appId\":\"20190513100506846790529\",\"sign\":\"c7bd0fc53430275ca3de1975ebe52e5f8b55d8b3c7b61cddb21dc1046bc4de9e\",\"nonceStr\":\"demoStr1561629575\",\"timestamp\":\"1561629575\"},\"auth\":{ \"authToken\":\"e7bae45c61936b189fd899b08ee72e54ed0258929038ba4a0b3bda6e7179\"},\"pay\":{ \"packet\":\"prepayOrderNo=20190627170635330573440\",\"sign\":\"a416f5b4a605bd223958e80f29c2261a0529076a512ba178329b57d5564da044\",\"nonceStr\":\"demoStr1561629575\",\"timestamp\":\"1561629575\"}}}";

            dynamic resDyn = JsonConvert.DeserializeObject(res);


            AuthResponse authResp = new AuthResponse() { ApplicationId = resDyn.data.appId, AuthToken = resDyn.data.authToken };

            //string result = authResp ?? null;

            return authResp;
        }
    }

    public class BaseResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public DataBase Data { get; set; }
    }
}
