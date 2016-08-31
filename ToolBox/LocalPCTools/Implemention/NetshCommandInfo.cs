using ToolBox.LocalPCTools.Unity;

namespace ToolBox.LocalPCTools.Implemention
{
    public class NetshCommandInfo:BaseCommandInfo
    {
        public NetshCommandInfo(ICommandModule module)
            : this("netsh", module.ToNetshCommdString())
        {
        }
        public NetshCommandInfo(string cmdType, string cmdStr) : base(cmdType, cmdStr)
        {
        }
    }
}
