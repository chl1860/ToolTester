using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.ClassTools.Interfaces
{
    public interface IClassAdapter
    {
        Dictionary<string, string> GetPropertyDic<T>(T obj);
        void SetPropertyValue<T>(T obj, string propName, string propVal);
        string GetClassName<T>(T obj);
        object ExecuteMethod<T>(string method, object[] paramters);
    }
}
