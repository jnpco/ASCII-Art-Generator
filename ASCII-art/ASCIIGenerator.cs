using System;
using System.Text;
using System.Drawing;
using System.Linq;

namespace ASCII_art
{
    class ASCIIGenerator
    {
        /**
         * "Ws@^/\";,. "
         * "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,"^`'. "
         * http://paulbourke.net/dataformats/asciiart/
         */
        public string CharRamp { get; set; }

        /**
         * Set to true if background is black (cmd, black terminal, black editor etc.).
         */
        public bool BlackBG { get; set; }

        /**
         * Default constructor.
         * Sets the default charRamp.
         */
        public ASCIIGenerator() 
            : this("$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\" ^`'. ") {}

        /**
         * Constructor that accepts a charRamp.
         * From darkest value.
         */
        public ASCIIGenerator(string CharRamp)
        {
            this.CharRamp = CharRamp;
        }
        
        /**
         * Creates a new bitmap and sends it to the Grayscale method.
         */
        public string GenerateASCII(Bitmap bmp)
        {
            return ImageToASCII(ImageUtils.Grayscale(bmp));
        }

        /**
         * Creates a new bitmap and sends it to the Grayscale method.
         */
        public string GenerateASCII(Bitmap bmp, int width)
        {
            return ImageToASCII(ImageUtils.Grayscale(ImageUtils.ResizeImage(bmp, width)));
        }
        
        /**
         * Generates ASCII from image.
         * Reverses string if BlackBG
         */
        private string ImageToASCII(Bitmap processedImage)
        {
            string CharRamp = BlackBG ? new string(this.CharRamp.Reverse().ToArray()) : this.CharRamp;

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
    }
}
