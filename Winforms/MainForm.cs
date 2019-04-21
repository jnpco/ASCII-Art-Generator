using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Core;

namespace Winforms
{
    public partial class MainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            InitDragFn();
            InitButtons();
            InitIO();
        }

        private void InitDragFn()
        {
            panel_Top.MouseMove += (s, e) => {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            };
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
