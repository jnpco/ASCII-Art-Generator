using System;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Core
{
    /// <summary>
    /// Utility class for image processing.
    /// </summary>
    class ImageUtils
    {
        /// <summary>
        /// Resizes an image to a specified width.
        /// </summary>
        /// <param name="bmp"> Source of the bitmap to be modified and returned. </param>
        /// <param name="width"> New width of the returned bitmap. </param>
        /// <returns> A new resized bitmap based on the param. </returns>
        public static Bitmap ResizeImage(Bitmap bmp, int width)
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

        /// <summary>
        /// Sets Contrast of image using lockbits.
        /// Note that the threshold should be a value between -100 and 100.
        /// </summary>
        /// <param name="bmp"> Source of the bitmap to be modified and returned. </param>
        /// <param name="threshold"> Values between -100 and 100, with 0 being the unmodified one.</param>
        /// <returns> A new bitmap with the specified contrast level. </returns>
        public static Bitmap SetContrast(Bitmap bmp, int threshold)
        {
            var modifiedContrast = new Bitmap(bmp);
            var lockedBitmap = new LockBitmap(modifiedContrast);
            lockedBitmap.LockBits();

            var contrast = Math.Pow((100.0 + threshold) / 100.0, 2);
            for (int y = 0; y < lockedBitmap.Height; y++)
            {
                for (int x = 0; x < lockedBitmap.Width; x++)
                {
                    var oldColor = lockedBitmap.GetPixel(x, y);
                    var red = ((((oldColor.R / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    var green = ((((oldColor.G / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    var blue = ((((oldColor.B / 255.0) - 0.5) * contrast) + 0.5) * 255.0;

                    if (red > 255) red = 255;
                    if (red < 0) red = 0;
                    if (green > 255) green = 255;
                    if (green < 0) green = 0;
                    if (blue > 255) blue = 255;
                    if (blue < 0) blue = 0;

                    var newColor = Color.FromArgb(oldColor.A, (int)red, (int)green, (int)blue);
                    lockedBitmap.SetPixel(x, y, newColor);
                }
            }
            lockedBitmap.UnlockBits();
            return modifiedContrast;
        }

        /// <summary>
        /// Grayscales an image using lockbits.
        /// </summary>
        /// <param name="bmp"> Source of the bitmap to be resized and returned. </param>
        /// <returns> A new grayscaled bitmap. </returns>
        public static Bitmap Grayscale(Bitmap bmp)
        {
            var grayScaled = new Bitmap(bmp);
            var lockedBitmap = new LockBitmap(grayScaled);
            lockedBitmap.LockBits();

            for (var y = 0; y < lockedBitmap.Height; y++)
            {
                for (var x = 0; x < lockedBitmap.Width; x++)
                {
                    var color = lockedBitmap.GetPixel(x, y);
                    var hsp = (int)RGBToHSP(color);
                    lockedBitmap.SetPixel(x, y, Color.FromArgb(hsp, hsp, hsp));
                }
            }
            lockedBitmap.UnlockBits();
            return grayScaled;
        }

        /// <summary>
        /// Calculates the brightness of a pixel.
        /// http://alienryderflex.com/hsp.html
        /// </summary>
        /// <param name="color"> Color to be calculated. </param>
        /// <returns></returns>
        public static double RGBToHSP(Color color)
        {
            return Math.Sqrt(
                color.R * color.R * 0.299 +
                color.G * color.G * 0.587 +
                color.B * color.B * 0.114
                );
        }
    }
}
