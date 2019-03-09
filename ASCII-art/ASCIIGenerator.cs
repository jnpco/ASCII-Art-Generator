using System;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        {
            this.CharRamp = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\" ^`'. ";
        }

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
            return ImageToASCII(Grayscale(bmp));
        }

        /**
         * Creates a new bitmap and sends it to the Grayscale method.
         */
        public string GenerateASCII(Bitmap bmp, int width)
        {
            return ImageToASCII(Grayscale(ResizeImage(bmp, width)));
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
        
        /**
         * Creates a new bitmap from the bitmap argument, which is helpful to avoid indexed bitmaps.
         */
        private Bitmap Grayscale(Bitmap bmp)
        {
            var grayScaled = new Bitmap(bmp);
            for (var y = 0; y < grayScaled.Height; y++)
            {
                for (var x = 0; x < grayScaled.Width; x++)
                {
                    var color = grayScaled.GetPixel(x, y);
                    var hsp = (int)RGBToHSP(color);
                    grayScaled.SetPixel(x, y, Color.FromArgb(hsp, hsp, hsp));
                }
            }
            return grayScaled;
        }

        /**
         * http://alienryderflex.com/hsp.html
         * Converts rgb to grayscale using hsp color model.
         */
        private double RGBToHSP(Color color)
        {
            return Math.Sqrt(
                color.R * color.R * 0.299 +
                color.G * color.G * 0.587 +
                color.B * color.B * 0.114
                );
        }

        /**
         * Resizes image keeping aspect ratio.
         */
        private Bitmap ResizeImage(Bitmap bmp, int width)
        {
            var ratio = (double)bmp.Height / bmp.Width;
            var height = (int)(width * ratio);

            var resized = new Bitmap(width, height);

            using (var g = Graphics.FromImage(resized))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;

                g.Clear(Color.White);
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return resized;
        }
    }
}
