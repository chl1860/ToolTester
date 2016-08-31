using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintDotNet.Data.PhotoshopFileType;
using PhotoshopFile;


namespace ToolBox.ImageTools
{
    public class PsdOperator
    {
        public PsdOperator()
        {
            
        }

        public void Execute(string fileName)
        {
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            //PsdLoad.Load(fileStream);
            var psd = new PsdFile(fileStream, Encoding.UTF8);
            var layers = psd.Layers;
            

        }
    }
}
