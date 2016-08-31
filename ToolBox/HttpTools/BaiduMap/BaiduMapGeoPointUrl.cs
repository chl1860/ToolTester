using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ToolBox.HttpTools.BaiduMap
{
    public class BaiduMapGeoPointUrl:IUrlGenerator
    {
        private readonly string m_Addr;
        public BaiduMapGeoPointUrl(string address)
        {
            m_Addr = address;
        }
        public string GetUrl()
        {
            var api = ConfigurationManager.AppSettings["BaiduMapGeoCoderApi"];
            var list = new List<string>
            {
                "address=" + m_Addr,
                "output=json",
                "ak=kqyuNF55EUSenEeRpfev0pHc&callback=showLocation"
            };

            var sbUrl = new StringBuilder();
            sbUrl.AppendFormat("{0}{1}", api, list.ToUrlParams());
            return sbUrl.ToString();
        }
    }
}
