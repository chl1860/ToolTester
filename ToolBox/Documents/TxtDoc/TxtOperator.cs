using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace ToolBox.Documents.TxtDoc
{
    public abstract class TxtOperator
    {
        public virtual string FolderPath
        {
            get { return ConfigurationManager.AppSettings["DesktopFolder"]; }
        }
        public virtual List<string> Read(string sourcePath)
        {
            var list = new List<string>();
            if (File.Exists(sourcePath))
            {
                var sr = new StreamReader(sourcePath, Encoding.Default);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }

            return list;
        }
        public virtual void Write(List<string> content, string targetPath)
        {
            using (var fs = new FileStream(targetPath, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    if (content.Count > 0)
                    {
                        foreach (var item in content)
                        {
                            sw.WriteLine(item);
                        }
                    }
                    sw.Flush();
                }
            }
        }
        public virtual void Append(List<string> content, string targetPath)
        {
            using (var fs = new FileStream(targetPath, FileMode.Append))
            {
                using (var sw = new StreamWriter(fs))
                {
                    if (content.Count > 0)
                    {
                        foreach (var item in content)
                        {
                            sw.WriteLine(item);
                        }
                    }
                    sw.Flush();
                }
            }
        }
    }
}
