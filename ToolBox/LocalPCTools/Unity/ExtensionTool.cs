using System.Text;

namespace ToolBox.LocalPCTools.Unity
{
    public static class ExtensionTool
    {
        public static string ToNetshCommdString(this ICommandModule module)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("interface ip set address \"Ethernet\" static {0} {1} {2}", module.IpAddress,
                module.SubnetMask, module.GateWay);
            return sb.ToString();
        }
    }
}
