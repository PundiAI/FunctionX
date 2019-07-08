using Newtonsoft.Json;

namespace Models
{
    public class DataJson
    {
        /*[JsonProperty("init")]
        public Init Init { get; set; }*/

        [JsonProperty("appId")]
        public string ApplicationId { get; set; }

        [JsonProperty("authToken")]
        public AuthResponse AuthToken { get; set; }
    }
}