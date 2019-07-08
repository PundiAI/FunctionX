using System;
using Newtonsoft.Json;

namespace Models
{
    
    public class Data
    {
        [JsonProperty("appId")]
        public string ApplicationId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("appOrderNo")]
        public string ApplicationOrderNumber { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }

        [JsonProperty("orderStatus")]
        public CommonEnums.OrderStatus OrderStatus { get; set; }

        [JsonProperty("orderTime")]
        public int OrderTime { get; set; }

        [JsonProperty("prepayOrderNo")]
        public string PrepayOrderNumber { get; set; }

        [JsonProperty("productDetail")]
        public string ProductDetail { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }


        public Data()
        {
        }
    }
}
