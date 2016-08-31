using System.Diagnostics;
using ToolBox.LocalPCTools.Unity;

namespace ToolBox.LocalPCTools
{
    public static class IpAddrOperator
    {
        public static void OpCommand(BaseCommandInfo commandInfo)
        {
            using (var p = new Process())
            {
                var psi = new ProcessStartInfo(commandInfo.ComdType,commandInfo.CommdString );
                p.StartInfo = psi;
                p.Start();
            }
        }

    }
}
