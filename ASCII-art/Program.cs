using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ASCII_art
{
    class Program
    {
        static void Main(string[] args)
        {
            string ascii = new ASCIIGenerator().GenerateASCII(args[0]);

            using (StreamWriter wrtr = new StreamWriter(args[1]))
            {
                wrtr.Write(ascii);
            }
        }
    }
}
