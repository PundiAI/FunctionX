using System;
using Newtonsoft.Json;

namespace Models
{
    public class OrderResponse
    {
        [JsonProperty("code", Required = Required.Always)]
        public int Code { get; set; }

        [JsonProperty("data", Required = Required.Always)]
        public Data Data { get; set; }


        [JsonProperty("msg")]
        public string Message { get; set; }

        public OrderResponse()
        {
        }


    }
}
