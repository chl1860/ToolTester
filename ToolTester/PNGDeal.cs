using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Documents.TxtDoc;

namespace ToolTester
{
    public class PNGDeal : TxtOperator
    {
        public List<string> GetPngs()
        {
            var str = string.Empty;
            var list = new List<string>();
            
            for (var i = 0; i < 24; i++)
            {
                str += (i < 10 ? "'Goal_TestAnim_0000" + i.ToString(CultureInfo.InvariantCulture) + ".png'" : "'Goal_TestAnim_000" + i + ".png'") + ",";
            }
            list.Add(str);
            return list;
        }
    }
}
