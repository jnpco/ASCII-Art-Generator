using System.Drawing;
using System.IO;

namespace ASCII_art
{
    class Program
    {
        static void Main(string[] args)
        {
            var imgLoc = @"C:\Path\To\File.img_extension";
            var imageToConvertToAscii = new Bitmap(imgLoc);

            // Preprocessing settings before converting to ascii. Both are optional.
            var bmpWidth = 100;
            var contrast = 100;

            var imgDestination = $@"C:\Path\To\File_{bmpWidth}_{contrast}.txt";

            // BmpWidth and contrast are optioonal.
            // BlackBG defaults to false. Set to true if displaying to dark backgrounds(ex: cmd, terminal).
            var ascii = new ASCIIGenerator() { BlackBG = false }.GenerateASCII(imageToConvertToAscii, bmpWidth, contrast);

            // Write ascii string to txt file.
            using (var w = new StreamWriter(imgDestination))
            {
                w.Write(ascii);
            }

            var asciiToImgDestination = @"C:\Path\To\ASCII_Img_File.img_extension";

            // Color and Font to be set to text, drawn to the image. Both optional.
            var font = new Font("Lucida Console", 6);
            var color = Color.Teal;

            // Resizing image. Optional.
            // Note that the unresized image generated from the ascii is typically 8x larger than the original image.
            var postProcessingWidth = 500;

            // Saves the bitmap generated to location specified.
            // postProcessingWidth, font, and color are optional.
            new ASCIIGenerator().ASCIIToImage(ascii, postProcessingWidth, font, color).Save(asciiToImgDestination);
        }
    }
}


