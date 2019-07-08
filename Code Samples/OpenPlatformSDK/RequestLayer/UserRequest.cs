using System;
using System.Security.Cryptography;
using HttpRequest;
using Models;
using Newtonsoft.Json;

namespace RequestLayer
{
    public class UserRequest
    {
        public UserRequest()
        {
        }

        public static UserResponse GetUserResponse(AuthResponse response)
        {
            var user = new User();
            user.ApplicationId = "201906191606516214096";
            user.TimeStamp = Common.GetCurrentTimestamp();
            user.RandomString = "demoStr1561629575";//Guid.NewGuid().ToString("N");
            user.AccessToken = response.AuthToken;

            string tmpSign = Common.AddSecretKey(user.ToString());
            user.Sign = Common.ComputeSha256Hash(tmpSign);

            MyHttpRequest request = new MyHttpRequest();
            var res = request.PostData(user.FullPath + "?" + user.ToString(), null, user.RequestMethod);

            dynamic resp = JsonConvert.DeserializeObject(res);

            UserResponse userResponse = new UserResponse() { ApplicationId = resp.data.appId };

            return userResponse;
        }
    }
}
