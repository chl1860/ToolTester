using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.ImageTools.Interfaces;

namespace ToolTester
{
    public class ImageOperator
    {
        private IImageOperator _imgOper = new ToolBox.ImageTools.ImageOperator();

        public void GenerateImage(string filePath,string newFilePath,int with,int height)
        {
            var b = _imgOper.GetResizedImage(filePath, with, height);
            b.Save(newFilePath);
        }
    }
}
