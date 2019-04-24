using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Winforms
{
    public partial class MessageBox : Form
    {
        #region Handle Panel Drag
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private string message;

        public MessageBox(string message)
        {
            InitializeComponent();
            this.message = message;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            panel_Message.Paint += (s, pe) =>
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                Rectangle area = new Rectangle(panel_Message.Location.X, panel_Message.Location.Y, panel_Message.Width, panel_Message.Height);
                pe.Graphics.DrawString(message, new Font("Century Gothic", 10), new SolidBrush(Color.DarkGray), area, sf);
            };

            InitComponents();
        }

        private void InitComponents()
        {
            InitTitleBar();
            InitButtons();
        }

        private void InitTitleBar()
        {
            // Handle Titlebar drag
            panel_Top.MouseMove += (s, e) => { if (e.Button == MouseButtons.Left) { ReleaseCapture(); SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); } };

            // Handle Titlebar clicks
            btn_Close.Click += (s, e) => this.Close();
        }

        private void InitButtons()
        {
            btn_Ok.Click += (s, e) => this.Close();
        }
    }
}
