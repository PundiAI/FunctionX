using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace HttpRequest
{
    public class MyHttpRequest
    {
        public MyHttpRequest()
        {
        }

        public  string PostData(string Url, string Data, string Method)
        {
            string result = null;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = Method;


            if (Method == "POST")
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(Data);

                }
            }


            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }
}
