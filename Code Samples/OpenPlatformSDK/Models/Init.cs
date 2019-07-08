using Newtonsoft.Json;

namespace Models
{
    public class Init :BaseClass
    {
        /*[JsonProperty("appId")]
        public string ApplicationId { get; set; }

        [JsonProperty("nonceStr")]
        public string RandomString { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }*/

        public Init(): base(""){}

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}