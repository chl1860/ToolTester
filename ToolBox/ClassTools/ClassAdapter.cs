using System;
using System.Collections.Generic;
using ToolBox.ClassTools.Interfaces;

namespace ToolBox.ClassTools
{
    public class ClassAdapter : IClassAdapter
    {
        /// <summary>
        /// Get dic of propName and propValue
        /// </summary>
        public Dictionary<string, string> GetPropertyDic<T>(T obj)
        {
            var dic = new Dictionary<string, string>();
            var t = typeof(T);
            var propertyList = t.GetProperties();

            if (propertyList.Length > 0)
            {
                foreach (var item in propertyList)
                {
                    var name = item.Name;
                    var val = Convert.ToString(item.GetValue(obj));
                    dic.Add(name, val);
                }
            }

            return dic;
        }

        /// <summary>
        /// Set propValue for special property
        /// </summary>
        public void SetPropertyValue<T>(T obj, string propName, string propVal)
        {
            var t = typeof(T);
            var propertyList = t.GetProperties();

            if (propertyList.Length > 0)
            {
                foreach (var item in propertyList)
                {
                    if (item.Name == propName)
                    {
                        item.SetValue(obj, propVal);
                    }
                }
            }
        }

        public string GetClassName<T>(T obj)
        {
            var t = typeof(T);
            return t.Name;
        }

        public object ExecuteMethod<T>(string method, object[] paramters)
        {
            var t = typeof(T);
            var obj = Activator.CreateInstance<T>();
            var mt = t.GetMethod(method);
            return mt.Invoke(obj, paramters);
        }

    }
}   
