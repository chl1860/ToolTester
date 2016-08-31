namespace ToolBox.LocalPCTools.Unity
{
    public class BaseCommandInfo
    {
        public BaseCommandInfo(string cmdType, string cmdStr)
        {
            ComdType = cmdType;
            CommdString = cmdStr;
        }
        public string ComdType { get; private set; }
        public string CommdString { get; private set; }
    }
}
