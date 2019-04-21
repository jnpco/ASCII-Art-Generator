using System;
using System.Drawing;
using System.Windows.Forms;
using Core;

namespace Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitButtons();
            InitIO();
        }

        private void InitButtons()
        {
            btn_Minimize.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
            btn_Info.Click += (s, e) => { };
            btn_Close.Click += (s, e) => { Application.Exit(); };
        }

        private void InitIO()
        {
            pBox_Input.AllowDrop = true;
            pBox_Input.DragEnter += (s, e) => { e.Effect = DragDropEffects.Copy; };

            pBox_Input.DragDrop += (s, e) => {
                foreach(string file in ((string[])e.Data.GetData(DataFormats.FileDrop)))
                {
                    Image image = Image.FromFile(file);
                    pBox_Input.Image = image;
                    pBox_Output.Image = GenerateASCIIImage(GenerateASCIIString((Bitmap)image));
                }
            };
        }

        string GenerateASCIIString(Bitmap image)
        {
            return new ASCIIGenerator() { BlackBG = false } .GenerateASCII(image);
        }

        Bitmap GenerateASCIIImage(string ascii)
        {
            return new ASCIIGenerator().ASCIIToImage(ascii);
        }

        void SaveImageToFile(Bitmap image, string destination)
        {
            image.Save(destination);
        }
    }
}
