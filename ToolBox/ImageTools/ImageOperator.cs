using System.Drawing;
using System.Drawing.Drawing2D;
using ToolBox.ImageTools.Interfaces;

namespace ToolBox.ImageTools
{
    public class ImageOperator:IImageOperator
    {
        public Bitmap GetResizedImage(string originalFile, int newWidth, int newHight)
        {
            try
            {
                var bitmap = new Bitmap(originalFile);
                var b = new Bitmap(newWidth, newHight);
                var g = Graphics.FromImage(b);
                // 插值算法的质量   
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(bitmap, new Rectangle(0, 0, newWidth, newHight), new Rectangle(0, 0, bitmap.Width, bitmap.Height), GraphicsUnit.Pixel);
                g.Dispose();
                return b;

            }
            catch
            {
                return null;
            }

        }
    }
}
