using System;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace ASCII_art
{
    class ImageUtils
    {
        /**
         * Resizes image keeping aspect ratio.
         */
        public Bitmap ResizeImage(Bitmap bmp, int width)
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

        /**
         * Creates a new bitmap from the bitmap argument, which is helpful to avoid indexed bitmaps.
         */
        public Bitmap Grayscale(Bitmap bmp)
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
        public double RGBToHSP(Color color)
        {
            return Math.Sqrt(
                color.R * color.R * 0.299 +
                color.G * color.G * 0.587 +
                color.B * color.B * 0.114
                );
        }
    }
}
