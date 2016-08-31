using System.Collections.Generic;
using ToolBox.Documents.TxtDoc;

namespace ToolBox.LocalPCTools.Implemention
{
    public class TxtIpNetConfig:ICommandModule
    {
        private readonly List<string> m_Content;
        public TxtIpNetConfig(TxtOperator txtOperator,string fileName)
            :this(txtOperator,txtOperator.FolderPath,fileName)
        {
            
        }
        public TxtIpNetConfig(TxtOperator txtOperator, string folderPath, string fileName)
        {
            var path = string.Format("{0}\\{1}", folderPath, fileName);
            m_Content = txtOperator.Read(path);
        } 
        public string IpAddress
        {
            get { return m_Content[0]; }
        }

        public string SubnetMask
        {
            get { return m_Content[1]; }
        }

        public string GateWay
        {
            get { return m_Content[2]; }
        }
    }
}
