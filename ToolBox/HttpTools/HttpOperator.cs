using System;
using System.IO;
using System.Net;
using System.Text;

namespace ToolBox.HttpTools
{
    public class HttpOperator
    {
        public string GetJson(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";

                var response = (HttpWebResponse)request.GetResponse();
                var myResponseStream = response.GetResponseStream();

                if (myResponseStream == null) return string.Empty;

                var myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                var retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();

                return retString;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
