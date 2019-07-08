using System;
using Newtonsoft.Json;

namespace Models
{
    public class Order : BaseClass
    {
        [JsonProperty("appOrderNo")]
        public string ApplicationOrderNumber { get; set; }


        [JsonProperty("attach")]
        public string Packet { get; set; }


        [JsonProperty("body")]
        public string ProductName { get; set; }

        [JsonProperty("detail")]
        public string ProductDetail { get; set; }

        [JsonProperty("currencyUnit")]
        public string CurrencyUnit { get; set; }

        [JsonProperty("amount")]
        public double CurrencyPrice { get; set; }

        [JsonProperty("num")]
        public int Quantity { get; set; }

        [JsonProperty("orderExpireTime")]
        public string OrderExpiryTime { get; set; }

        public Order() : base("/api/v1/order")
        {
            RequestMethod = "POST";
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
