using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Core;

namespace Winforms
{
    public partial class MainForm : Form
    {
        // TODO Validations, Size validations (Min, Max) Generate Size.
        // TODO Font Combobox
        // TODO Add switch for colored, greyscale, or custom color.

        #region Handle Panel Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private Button colorModeSelected;
        private Button[] colorModes;

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

            // Color Mode
            colorModes = new Button[] { btn_SettingsGreyscaled, btn_SettingsColored, btn_SettingsCustom};
            setColorModeSelected(colorModes[0]);
            foreach(Button colorMode in colorModes) { colorMode.Click += (s, e) => { switchColorMode(colorMode); }; }
        }

        void setColorModeSelected(Button colorMode)
        {
            colorModeSelected = colorMode;
            colorModeSelected.BackColor = Color.DarkSlateBlue;
        }

        void switchColorMode(Button colorMode)
        {
            if (colorModeSelected != colorMode)
            {
                colorModeSelected.BackColor = Color.FromArgb(61, 61, 61);
                setColorModeSelected(colorMode);
            }
        }

        string GenerateASCIIString(Bitmap image)
        {
            int width;
            int contrast = slider_Contrast.Value * 10;
            Font font = new Font(txt_FontFamily.Text, Int32.Parse(txt_FontSize.Text)); // No need for checks because this will be a combobox.

            if (!Int32.TryParse(txt_Width.Text, out width))
            {
                width = pBox_Input.Width;
                txt_Width.Text = width.ToString();
            }

            return new ASCIIGenerator() { BlackBG = false } .GenerateASCII(image, width, contrast);
        }

        Bitmap GenerateASCIIImage(string ascii)
        {
            Font font = new Font(txt_FontFamily.Text, Int32.Parse(txt_FontSize.Text));
            return new ASCIIGenerator().ASCIIToImage(ascii, pBox_Input.Width, font, Color.Black);
        }
    }
}
