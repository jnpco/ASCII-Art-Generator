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
         * Returns an ascii string from the processed image. 
         * Processesing done: Grayscaling.
         */
        public string GenerateASCII(Bitmap bmp)
        {
            return ImageToASCII(ImageUtils.Grayscale(bmp));
        }

        /**
         * Returns an ascii string from the processed image. 
         * Processesing done: Grayscaling, Resizing.
         */
        public string GenerateASCII(Bitmap bmp, int width)
        {
            return ImageToASCII(ImageUtils.Grayscale(ImageUtils.ResizeImage(bmp, width)));
        }

        /**
         * Returns an ascii string from the processed image. 
         * Processesing done: Grayscaling, Resizing, Contrast.
         */
        public string GenerateASCII(Bitmap bmp, int width, int contrastThreshold)
        {
            return ImageToASCII(ImageUtils.Grayscale(ImageUtils.ResizeImage(ImageUtils.SetContrast(bmp, contrastThreshold), width)));
        }

        /**
         * Generates ASCII from image.
         * Reverses string if BlackBG
         */
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

        /**
         * Creates an image from ascii string.
         */
        public Bitmap ASCIIToImage(string ascii)
        {
            var font = new Font("Lucida Console", 6);
            var dim = Graphics.FromImage(new Bitmap(1, 1)).MeasureString(ascii, font);
            return ASCIIToImage(ascii, (int)dim.Width);
        }

        /**
         * Creates an image from ascii string and resizes it.
         */
        public Bitmap ASCIIToImage(string ascii, int width)
        {
            var font = new Font("Lucida Console", 6);
            return ASCIIToImage(ascii, width, font);
        }

        /**
         * Creates an image from ascii string with specified font and resizes it.
         */
        public Bitmap ASCIIToImage(string ascii, int width, Font font)
        {
            return ASCIIToImage(ascii, width, font, Color.Black);
        }

        /**
         * Creates an image from ascii string with specified font and color, then resizes it.
         */
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
