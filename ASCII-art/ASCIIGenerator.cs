using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASCII_art
{
    class ASCIIGenerator
    {
        string imageLoc;

        public ASCIIGenerator(string imageLoc)
        {
            this.imageLoc = imageLoc;
        }

        public void convert(string saveLoc)
        {
            var bmp = new Bitmap();
        }
    }
}
