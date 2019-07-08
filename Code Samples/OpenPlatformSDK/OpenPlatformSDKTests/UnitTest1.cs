using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RequestLayer;

namespace OpenPlatformSDKTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAuthToken()
        {
            var authTokenRequest = AuthRequest.GetAuthResponse();
            Console.WriteLine(authTokenRequest.AuthToken);

            Assert.IsNotNull(authTokenRequest);
        }

        [TestMethod]
        public void GetUserInfo()
        {
            var authTokenRequest = AuthRequest.GetAuthResponse();
            var userResp = UserRequest.GetUserResponse(authTokenRequest);
            Assert.IsNotNull(userResp);
        }
    }
}
