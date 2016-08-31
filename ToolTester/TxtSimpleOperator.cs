using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Documents.TxtDoc;

namespace ToolTester
{
    public class TxtSimpleOperator:TxtOperator
    {
        public override List<string> Read(string fileName)
        {
            var str = GetString(base.Read(base.FolderPath+"\\"+fileName));
            
            return new List<string> {str};
        }

        private string GetString(List<string> list )
        {
            var result = string.Empty;

            if (null != list && list.Count > 0)
            {
                foreach (var item in list)
                {
                    result += "'" + item + "',";
                }
            }
            return result;
        }
    }
}
