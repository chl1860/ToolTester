using System.Configuration;
using ToolBox.LocalPCTools.Unity;

namespace ToolBox.LocalPCTools.Implemention
{
    public class IpConfigModule : ICommandModule
    {
        public string IpAddress
        {
            get { return GetAppInof(EnumOption.IpAddr); }
        }

        public string SubnetMask
        {
            get { return GetAppInof(EnumOption.SubnetMask); }
        }

        public string GateWay
        {
            get { return GetAppInof(EnumOption.GateWays); }
        }
        public string Dns
        {
            get { return GetAppInof(EnumOption.Dns); }
        }

        private string GetAppInof(EnumOption option)
        {
            string method;
            switch (option)
            {
                case EnumOption.SubnetMask:
                    method = "SubnetMask";
                    break;
                case EnumOption.GateWays:
                    method = "GateWays";
                    break;
                default:
                    method = "IpV4Address";
                    break;
            }

            return ConfigurationManager.AppSettings[method];
        }
    }

}
