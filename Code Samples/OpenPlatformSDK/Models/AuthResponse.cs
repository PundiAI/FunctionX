using System;
using Newtonsoft.Json;

namespace Models
{
    public class AuthResponse
    {
        [JsonProperty("appId")]
        public string ApplicationId { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        public AuthResponse()
        {
        }
    }
}
