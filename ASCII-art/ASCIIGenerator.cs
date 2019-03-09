using System;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ASCII_art
{
    class ASCIIGenerator
    {
        /**
         * http://paulbourke.net/dataformats/asciiart/
         * "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,"^`'. "
         */
        readonly string charRamp = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\" ^`'. ";

        public string GenerateASCII(string imageLoc, int width)
        {
            var processedImage = ProcessImage(imageLoc, width);
            var sb = new StringBuilder();

            for (var y = 0; y < processedImage.Height; y++)
            {
                for (var x = 0; x < processedImage.Width; x++)
                {
                    var index = (double)processedImage.GetPixel(x, y).B / 255 * (charRamp.Length - 1);
                    sb.Append(charRamp[(int)index]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        /**
         * Creates a new bitmap and sends it to the Grayscale method.
         */
        private Bitmap ProcessImage(string imgLoc, int width)
        {
            return Grayscale(ResizeImage(new Bitmap(imgLoc), width));
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
         */
        private double RGBToHSP(Color color)
        {
            return Math.Sqrt(
                color.R * color.R * 0.299 +
                color.G * color.G * 0.587 +
                color.B * color.B * 0.114
                );
        }

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
