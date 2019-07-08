using System;
using Newtonsoft.Json;

namespace Models
{
    public class DataBase
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public DataJson Data { get; set; }

        

        [JsonProperty("msg")]
        public string Message { get; set; }

        public DataBase()
        {
        }
    }
}
