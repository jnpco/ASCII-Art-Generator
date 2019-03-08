using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ASCII_art
{
    class ASCIIGenerator
    {
        string imageLoc;

        public ASCIIGenerator(string imageLoc)
        {
            this.imageLoc = imageLoc;
        }

        public void Convert(string saveLoc)
        {
            var bmp = new Bitmap(imageLoc);
            using (var writer = new StreamWriter(saveLoc))
            {
                for (var y = 0; y < bmp.Height; y++)
                {
                    for (var x = 0; x < bmp.Width; x++)
                    {
                        var color = bmp.GetPixel(x, y);
                    }
                }
            }
        }

        //http://alienryderflex.com/hsp.html
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
