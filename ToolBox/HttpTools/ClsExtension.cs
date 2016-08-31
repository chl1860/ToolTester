using System.Collections.Generic;
using System.Linq;

namespace ToolBox.HttpTools
{
    public static class ClsExtension
    {
        public static string ToUrlParams(this List<string> list)
        {
            var strParams = string.Empty;
            if (list.Count <= 0) return strParams;
            strParams = list.Aggregate(strParams, (current, item) => current + (item + "&"));
            strParams = strParams.Remove(strParams.Length - 1);
            strParams = "?" + strParams;
            return strParams;
        }
    }
}
