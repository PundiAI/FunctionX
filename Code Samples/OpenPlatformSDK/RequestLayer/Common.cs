using System;
using System.Security.Cryptography;
using System.Text;

namespace RequestLayer
{
    public class Common
    {
        internal static string _secret = "pM79GoQcLHim4wLgogOzrw==";

        public Common()
        {
        }

        public static int GetCurrentTimestamp()
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var unixDateTime = (DateTime.Now.ToUniversalTime() - epoch).TotalSeconds;

            return (int)unixDateTime;
        }

        public static string ComputeSha256Hash(string rawData)
        {
            var encoding = new System.Text.UTF8Encoding();
            var bSecret = encoding.GetBytes(_secret);
            
            /*using (HMACSHA256 hash = new HMACSHA256(bSecret))
            {
                byte[] b = encoding.GetBytes(rawData);
                var hashMessage = hash.ComputeHash(b);

                // Convert byte array to a string   
                StringBuilder sBuilder = new StringBuilder();
                for (int i = 0; i < hashMessage.Length; i++)
                {
                    sBuilder.Append(hashMessage[i].ToString("x2"));
                }
                return Convert.ToBase64String(hashMessage);
            }*/

          
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {

                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        internal static string AddSecretKey(string v)
        {
            return v + "pM79GoQcLHim4wLgogOzrw==";
        }
    }
}
