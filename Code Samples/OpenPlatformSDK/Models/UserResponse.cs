using System;
using Newtonsoft.Json;

namespace Models
{
    public class UserResponse
    {
        [JsonProperty("appId")]
        public string ApplicationId { get; set; }

        [JsonProperty("openId")]
        public string UserId { get; set; }


        [JsonProperty("unionId")]
        public string UnionId { get; set; }

        [JsonProperty("nickName")]
        public string Nickname { get; set; }

        [JsonProperty("profilePicture")]
        public string Avatar { get; set; }

        [JsonProperty("gender")]
        public CommonEnums.Gender Gender { get; set; }
        public UserResponse()
        {
        }
    }
}
