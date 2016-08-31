using System.Collections.Generic;
using ToolBox.Documents.TxtDoc;

namespace ToolTester
{
    public class TxtTestOperator:TxtOperator
    {
        public override void Write(List<string> content, string fileName)
        {
            var path = string.Format("{0}\\{1}", base.FolderPath, fileName);
            base.Write(content,path);
        }

        public override void Append(List<string> content, string fileName)
        {
            var path = string.Format("{0}\\{1}", base.FolderPath, fileName);
            base.Append(content, path);
        }
    }
}
