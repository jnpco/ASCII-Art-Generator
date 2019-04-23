using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Core;
using System.Drawing.Text;

namespace Winforms
{
    struct ColorModeSwitch
    {
        public enum ColorMode { GREYSCALED, COLORED, CUSTOM }

        public Button component;
        public ColorMode colorMode;

        public ColorModeSwitch(Button component, ColorMode colorMode)
        {
            this.component = component;
            this.colorMode = colorMode;
        }
    }

    public partial class MainForm : Form
    {
        #region Handle Panel Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Initializing MonospacedFonts
        #endregion

        private enum SaveMode { TEXT, IMAGE, HTML }
        
        private Button colorModeSelected;
        private Button[] colorModes;

        private Color colorModeActive;
        private Color colorModeInactive;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitComponents();
            colorModeActive = Color.DarkSlateBlue;
            colorModeInactive = Color.FromArgb(61, 61, 61);
        }

        private void InitComponents()
        {
            // Handle Titlebar drag
            panel_Top.MouseMove += (s, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

            // Handle Titlebar clicks
            btn_Minimize.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
            btn_Info.Click += (s, e) => { };
            btn_Close.Click += (s, e) => { Application.Exit(); };

            // Handle P_Box events
            pBox_Input.AllowDrop = true;
            pBox_Input.DragEnter += (s, e) => { e.Effect = DragDropEffects.Copy; };
            pBox_Input.DragDrop += (s, e) => { pBox_Input.Image = Image.FromFile( ((string[])e.Data.GetData(DataFormats.FileDrop))[0] ); };

            // Handle Color Modes
            colorModes = new Button[] { btn_SettingsGreyscaled, btn_SettingsColored, btn_SettingsCustom};
            SetColorModeSelected(colorModes[0]);
            foreach(Button colorMode in colorModes) { colorMode.Click += (s, e) => { SwitchColorMode(colorMode); }; }

            // Handle Save and Generate clicks
            btn_OutputText.Click += (s, e) => { SaveOutput(SaveMode.TEXT); };
            btn_OutputImage.Click += (s, e) => { SaveOutput(SaveMode.IMAGE); };
            btn_OutputHTML.Click += (s, e) => { SaveOutput(SaveMode.HTML); };
            btn_Generate.Click += (s, e) => { pBox_Output.Image = GenerateASCIIImage(GenerateASCIIString()); };
        }

        private void SetColorModeSelected(Button colorMode)
        {
            colorModeSelected = colorMode;
            colorModeSelected.BackColor = colorModeInactive;
        }

        private void SwitchColorMode(Button colorMode)
        {
            if (colorModeSelected != colorMode)
            {
                colorModeSelected.BackColor = colorModeActive;
                SetColorModeSelected(colorMode);
            }
        }

        private void SaveOutput(SaveMode saveMode)
        {
            switch (saveMode)
            {
                case SaveMode.TEXT:
                    break;
                case SaveMode.IMAGE:
                    break;
                case SaveMode.HTML:
                    break;
                default:
                    break;
            }
        }

        private string GenerateASCIIString()
        {
            int width;
            int contrast = slider_Contrast.Value * 10;
            Font font = new Font(txt_FontFamily.Text, Int32.Parse(txt_FontSize.Text));

            if (!Int32.TryParse(txt_Width.Text, out width))
            {
                width = pBox_Input.Width;
                txt_Width.Text = width.ToString();
            }

            return new ASCIIGenerator() { BlackBG = false } .GenerateASCII((Bitmap)pBox_Input.Image, width, contrast);
        }

        private Bitmap GenerateASCIIImage(string ascii)
        {
            Font font = new Font(txt_FontFamily.Text, Int32.Parse(txt_FontSize.Text));
            return new ASCIIGenerator().ASCIIToImage(ascii, pBox_Input.Width, font, Color.Black);
        }

    }
}
