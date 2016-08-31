using System.Drawing;

namespace ToolBox.ImageTools.Interfaces
{
    public interface IImageOperator
    {
        /// <summary>
        /// Resize original image
        /// </summary>
        /// <param name="originalFile">file name and file path</param>
        /// <param name="newW">New width</param>
        /// <param name="newH">New height</param>
        /// <returns></returns>
        Bitmap GetResizedImage(string originalFile, int newW, int newH);
    }
}
