using System;
using System.Text;
using System.Drawing;

namespace ASCII_art
{
    class ASCIIGenerator
    {
        /**
         * http://paulbourke.net/dataformats/asciiart/
         * "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,"^`'. "
         */
        readonly string charRamp = "$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\\|()1{}[]?-_+~<>i!lI;:,\" ^`'. ";

        public string GenerateASCII(string imageLoc)
        {
            var grayScaled = Grayscale(imageLoc);
            var sb = new StringBuilder();

            for (var y = 0; y < grayScaled.Height; y++)
            {
                for (var x = 0; x < grayScaled.Width; x++)
                {
                    var index = (double)grayScaled.GetPixel(x, y).R / 255 * (charRamp.Length - 1);
                    sb.Append(charRamp[(int)index]);
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        public Bitmap Grayscale(string imgLoc)
        {
            Bitmap grayScaled = new Bitmap(imgLoc);
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
    }
}
