using System;
using System.Text;
using System.Drawing;
using System.Linq;

namespace Core
{
    public class ASCIIGenerator
    {

        /*
         * Sample charRamp.
         * "Ws@^/\";,. "
         * "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,"^`'. "
         */

        /// <summary>
        /// Characters to be used in the ascii string. Characters should go from darkest to brightest.
        /// <para>http://paulbourke.net/dataformats/asciiart/</para>
        /// </summary>
        public string CharRamp { get; set; }

        /// <summary>
        /// Set to true if background is black (cmd, black terminal, black editor etc.).
        /// </summary>
        public bool BlackBG { get; set; }
        
        /// <summary>
        /// Default constructor.
        /// Sets the default charRamp.
        /// </summary>
        public ASCIIGenerator() 
            : this("$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\" ^`'. ") { }

        /// <summary>
        /// Constructor that accepts a custom charRamp.
        /// </summary>
        /// <param name="CharRamp"> Initializes the charRamp property. </param>
        public ASCIIGenerator(string CharRamp)
        {
            this.CharRamp = CharRamp;
        }

        /// <summary>
        ///  Processesing done: Grayscaling.
        /// </summary>
        /// <param name="bmp"> Source of the bitmap to be processed and passed to the ImageToASCII method. </param>
        /// <returns> Ascii string from the processed image. </returns>
        public string GenerateASCII(Bitmap bmp)
        {
            return ImageToASCII(ImageUtils.Grayscale(bmp));
        }

        /// <summary>
        ///  Processesing done: Grayscaling, Resizing.
        /// </summary>
        /// <param name="bmp"> Source of the bitmap to be processed and passed to the ImageToASCII method. </param>
        /// <returns> Ascii string from the processed image. </returns>
        public string GenerateASCII(Bitmap bmp, int width)
        {
            return ImageToASCII(ImageUtils.Grayscale(ImageUtils.ResizeImage(bmp, width)));
        }

        /// <summary>
        ///  Processesing done: Grayscaling, Resizing, Contrast Adjustment.
        /// </summary>
        /// <param name="bmp"> Source of the bitmap to be processed and passed to the ImageToASCII method. </param>
        /// <returns> Ascii string from the processed image. </returns>
        public string GenerateASCII(Bitmap bmp, int width, int contrastThreshold)
        {
            return ImageToASCII(ImageUtils.Grayscale(ImageUtils.ResizeImage(ImageUtils.SetContrast(bmp, contrastThreshold), width)));
        }

        /// <summary>
        /// Method called by the GenerateASCII. Assigns each pixel to a character from the charRamp string.
        /// </summary>
        /// <param name="processedImage"> Processed bitmap to be converted to an ascii string.</param>
        /// <returns> Ascii string from the processed image. </returns>
        private string ImageToASCII(Bitmap processedImage)
        {
            var CharRamp = BlackBG ? new string(this.CharRamp.Reverse().ToArray()) : this.CharRamp;

            var sb = new StringBuilder();

            for (var y = 0; y < processedImage.Height; y++)
            {
                for (var x = 0; x < processedImage.Width; x++)
                {
                    var index = (double)processedImage.GetPixel(x, y).B / 255 * (CharRamp.Length - 1);
                    sb.Append(CharRamp[(int)index]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Generates an image from ascii string.
        /// <para> * Note that the default generated image is approx. > 8 times larger than the source bitmap as 1 character is mapped to a pixel. </para>
        /// </summary>
        /// <param name="ascii"> String to be drawn to the empty bitmap </param>
        /// <returns> An image that drawn with the ascii string. </returns>
        public Bitmap ASCIIToImage(string ascii)
        {
            var font = new Font("Lucida Console", 6);
            var dim = Graphics.FromImage(new Bitmap(1, 1)).MeasureString(ascii, font);
            return ASCIIToImage(ascii, (int)dim.Width);
        }

        /// <summary>
        /// Generates an image from ascii string.
        /// </summary>
        /// <param name="ascii"> String to be drawn to the empty bitmap </param>
        /// <param name="width"> Width of the newly created bitmap. </param>
        /// <returns> An image that drawn with the ascii string. </returns>
        public Bitmap ASCIIToImage(string ascii, int width)
        {
            var font = new Font("Lucida Console", 6);
            return ASCIIToImage(ascii, width, font);
        }


        /// <summary>
        /// Generates an image from ascii string.
        /// </summary>
        /// <param name="ascii"> String to be drawn to the empty bitmap </param>
        /// <param name="width"> Width of the newly created bitmap. </param>
        /// <param name="font"> Font to be set when drawing the ascii string. <para> * Use monospaced fonts only. </para></param>
        /// <returns> An image that drawn with the ascii string. </returns>
        public Bitmap ASCIIToImage(string ascii, int width, Font font)
        {
            return ASCIIToImage(ascii, width, font, Color.Black);
        }


        /// <summary>
        /// Generates an image from ascii string.
        /// </summary>
        /// <param name="ascii"> String to be drawn to the empty bitmap </param>
        /// <param name="width"> Width of the newly created bitmap. </param>
        /// <param name="font"> Font to be set when drawing the ascii string. <para> * Use monospaced fonts only. </para></param>
        /// <param name="color"> Font color. </param>
        /// <returns> An image that drawn with the ascii string. </returns>
        public Bitmap ASCIIToImage(string ascii, int width, Font font, Color color)
        {
            var asciiLines = ascii.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            var dim = Graphics.FromImage(new Bitmap(1, 1)).MeasureString(ascii, font);
            var asciiImage = new Bitmap((int)dim.Width, (int)dim.Height);

            using (Graphics g = Graphics.FromImage(asciiImage))
            {
                for (int i = 0; i < asciiLines.Length; i++)
                {
                    g.DrawString(asciiLines[i], font, new SolidBrush(color), 0, i * font.Height);
                }
            }
            return ImageUtils.ResizeImage(asciiImage, width);
        }
    }
}
