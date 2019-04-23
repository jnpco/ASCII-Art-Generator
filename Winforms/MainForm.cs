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
            InitComponents();
        }

        private void InitComponents()
        {
            // Handle Dragging of panel
            panel_Top.MouseMove += (s, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

            // Handle Button clicks
            btn_Generate.Click += (s, e) => { pBox_Output.Image = GenerateASCIIImage(GenerateASCIIString((Bitmap)pBox_Input.Image)); };
            btn_Minimize.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
            btn_Info.Click += (s, e) => { };
            btn_Close.Click += (s, e) => { Application.Exit(); };

            // Handle P_Box events
            pBox_Input.AllowDrop = true;
            pBox_Input.DragEnter += (s, e) => { e.Effect = DragDropEffects.Copy; };
            pBox_Input.DragDrop += (s, e) => { pBox_Input.Image = Image.FromFile( ((string[])e.Data.GetData(DataFormats.FileDrop))[0] ); };
        }

        string GenerateASCIIString(Bitmap image)
        {
            return new ASCIIGenerator() { BlackBG = false } .GenerateASCII(image, pBox_Input.Width, slider_Contrast.Value * 10);
        }

        Bitmap GenerateASCIIImage(string ascii)
        {
            return new ASCIIGenerator().ASCIIToImage(ascii, Int32.Parse(txt_Width.Text), new Font(txt_FontFamily.Text, Int32.Parse(txt_FontSize.Text)), Color.Black);
        }

        void SaveImageToFile(Bitmap image, string destination)
        {
            image.Save(destination);
        }
    }
}
