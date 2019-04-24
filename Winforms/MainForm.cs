using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Core;

namespace Winforms
{
    struct ColorModeSwitch
    {
        public enum Mode { GREYSCALED, COLORED, CUSTOM }

        public Button component;
        public Mode mode;

        public ColorModeSwitch(Button component, Mode mode)
        {
            this.component = component;
            this.mode = mode;
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

        private enum SaveMode { TEXT, IMAGE, HTML }
        
        private ColorModeSwitch colorModeSelected;
        private ColorModeSwitch[] colorModes;

        private Color colorModeActive;
        private Color colorModeInactive;

        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitComponents();
            
            this.Paint += (s, pe) =>
            {
                foreach (FontFamily fontFamily in FontFamily.Families)
                {
                    cBox_FontName.Items.Add(fontFamily.Name.ToString());
                }
            };
        }

        private void InitComponents()
        {
            InitTitleBar();
            InitPBox(); 
            InitColorModes();
            InitOutputGenerate();
        }

        private void InitTitleBar()
        {
            // Handle Titlebar drag
            panel_Top.MouseMove += (s, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

            // Handle Titlebar clicks
            btn_Minimize.Click += (s, e) => { this.WindowState = FormWindowState.Minimized; };
            btn_Info.Click += (s, e) => { };
            btn_Close.Click += (s, e) => { Application.Exit(); };
        }

        private void InitPBox()
        {
            // Handle P_Box events
            pBox_Input.AllowDrop = true;
            pBox_Input.DragEnter += (s, e) => { e.Effect = DragDropEffects.Copy; };
            pBox_Input.DragDrop += (s, e) => { pBox_Input.Image = Image.FromFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]); };
        }

        private void InitColorModes()
        {

            // Handle Color Modes
            colorModeActive = Color.DarkSlateBlue;
            colorModeInactive = Color.FromArgb(61, 61, 61);

            colorModes = new ColorModeSwitch[]
            {
                new ColorModeSwitch(btn_SettingsGreyscaled, ColorModeSwitch.Mode.GREYSCALED),
                new ColorModeSwitch(btn_SettingsColored, ColorModeSwitch.Mode.COLORED),
                new ColorModeSwitch(btn_SettingsCustom, ColorModeSwitch.Mode.CUSTOM)
            };
            SetColorModeSelected(colorModes[0]);
            foreach (ColorModeSwitch colorMode in colorModes) { colorMode.component.Click += (s, e) => { SwitchColorMode(colorMode); }; }

        }

        private void InitOutputGenerate()
        {
            // Handle Save and Generate clicks
            btn_OutputText.Click += (s, e) => { SaveOutput(SaveMode.TEXT); };
            btn_OutputImage.Click += (s, e) => { SaveOutput(SaveMode.IMAGE); };
            btn_OutputHTML.Click += (s, e) => { SaveOutput(SaveMode.HTML); };
            btn_Generate.Click += (s, e) => { pBox_Output.Image = GenerateASCIIImage(GenerateASCIIString()); };
        }

        private void SetColorModeSelected(ColorModeSwitch colorMode)
        {
            colorModeSelected = colorMode;
            colorModeSelected.component.BackColor = colorModeActive;
        }

        private void SwitchColorMode(ColorModeSwitch colorMode)
        {
            if (colorModeSelected.mode != colorMode.mode)
            {
                colorModeSelected.component.BackColor = colorModeInactive;
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
            Font font = new Font(cBox_FontName.Text, Int32.Parse(cBox_FontSize.Text));

            if (!Int32.TryParse(txt_Width.Text, out width))
            {
                width = pBox_Input.Width;
                txt_Width.Text = width.ToString();
            }

            return new ASCIIGenerator() { BlackBG = false } .GenerateASCII((Bitmap)pBox_Input.Image, width, contrast);
        }

        private Bitmap GenerateASCIIImage(string ascii)
        {
            Font font = new Font(cBox_FontName.Text, Int32.Parse(cBox_FontSize.Text));
            return new ASCIIGenerator().ASCIIToImage(ascii, pBox_Input.Width, font, Color.Black);
        }

    }
}
