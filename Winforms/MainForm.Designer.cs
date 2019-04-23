namespace Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Right = new System.Windows.Forms.Panel();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.lbl_Log = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.btn_OutputHTML = new System.Windows.Forms.Button();
            this.btn_OutputImage = new System.Windows.Forms.Button();
            this.btn_OutputText = new System.Windows.Forms.Button();
            this.grp_Settings = new System.Windows.Forms.GroupBox();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.txt_FontFamily = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.txt_FontSize = new System.Windows.Forms.TextBox();
            this.lbl_SizeSettings = new System.Windows.Forms.Label();
            this.lbl_FontSettings = new System.Windows.Forms.Label();
            this.lbl_ContrastDefault = new System.Windows.Forms.Label();
            this.lbl_ContrastMaximum = new System.Windows.Forms.Label();
            this.lbl_ContrastMinimum = new System.Windows.Forms.Label();
            this.slider_Contrast = new System.Windows.Forms.TrackBar();
            this.pBox_Output = new System.Windows.Forms.PictureBox();
            this.pBox_Input = new System.Windows.Forms.PictureBox();
            this.btn_SettingsCustom = new System.Windows.Forms.Button();
            this.btn_SettingsColored = new System.Windows.Forms.Button();
            this.btn_SettingsGreyscaled = new System.Windows.Forms.Button();
            this.pBox_Logo = new System.Windows.Forms.PictureBox();
            this.cBox_AspectRatio = new System.Windows.Forms.CheckBox();
            this.panel_Right.SuspendLayout();
            this.panel_Top.SuspendLayout();
            this.grp_Output.SuspendLayout();
            this.grp_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.panel_Right.Controls.Add(this.btn_Generate);
            this.panel_Right.Controls.Add(this.pBox_Output);
            this.panel_Right.Controls.Add(this.lbl_Log);
            this.panel_Right.Controls.Add(this.panel_Top);
            this.panel_Right.Controls.Add(this.grp_Output);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(309, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(660, 681);
            this.panel_Right.TabIndex = 7;
            // 
            // btn_Generate
            // 
            this.btn_Generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Generate.FlatAppearance.BorderSize = 0;
            this.btn_Generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Generate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Generate.Location = new System.Drawing.Point(466, 605);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(147, 58);
            this.btn_Generate.TabIndex = 13;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = false;
            // 
            // lbl_Log
            // 
            this.lbl_Log.AutoSize = true;
            this.lbl_Log.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Log.Location = new System.Drawing.Point(448, 659);
            this.lbl_Log.MinimumSize = new System.Drawing.Size(200, 0);
            this.lbl_Log.Name = "lbl_Log";
            this.lbl_Log.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Log.Size = new System.Drawing.Size(200, 13);
            this.lbl_Log.TabIndex = 20;
            this.lbl_Log.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.btn_Close);
            this.panel_Top.Controls.Add(this.btn_Info);
            this.panel_Top.Controls.Add(this.btn_Minimize);
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(660, 46);
            this.panel_Top.TabIndex = 19;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Close.Location = new System.Drawing.Point(627, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // btn_Info
            // 
            this.btn_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Info.Location = new System.Drawing.Point(591, 3);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(30, 30);
            this.btn_Info.TabIndex = 20;
            this.btn_Info.UseVisualStyleBackColor = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Minimize.Location = new System.Drawing.Point(555, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 19;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.btn_OutputHTML);
            this.grp_Output.Controls.Add(this.btn_OutputImage);
            this.grp_Output.Controls.Add(this.btn_OutputText);
            this.grp_Output.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Output.ForeColor = System.Drawing.Color.DarkGray;
            this.grp_Output.Location = new System.Drawing.Point(45, 590);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(374, 83);
            this.grp_Output.TabIndex = 26;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "SAVE";
            // 
            // btn_OutputHTML
            // 
            this.btn_OutputHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_OutputHTML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OutputHTML.FlatAppearance.BorderSize = 0;
            this.btn_OutputHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutputHTML.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutputHTML.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_OutputHTML.Location = new System.Drawing.Point(240, 22);
            this.btn_OutputHTML.Name = "btn_OutputHTML";
            this.btn_OutputHTML.Size = new System.Drawing.Size(83, 45);
            this.btn_OutputHTML.TabIndex = 12;
            this.btn_OutputHTML.Text = "HTML";
            this.btn_OutputHTML.UseVisualStyleBackColor = false;
            // 
            // btn_OutputImage
            // 
            this.btn_OutputImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_OutputImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OutputImage.FlatAppearance.BorderSize = 0;
            this.btn_OutputImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutputImage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutputImage.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_OutputImage.Location = new System.Drawing.Point(151, 22);
            this.btn_OutputImage.Name = "btn_OutputImage";
            this.btn_OutputImage.Size = new System.Drawing.Size(83, 45);
            this.btn_OutputImage.TabIndex = 11;
            this.btn_OutputImage.Text = "Image";
            this.btn_OutputImage.UseVisualStyleBackColor = false;
            // 
            // btn_OutputText
            // 
            this.btn_OutputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_OutputText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OutputText.FlatAppearance.BorderSize = 0;
            this.btn_OutputText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutputText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutputText.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_OutputText.Location = new System.Drawing.Point(62, 22);
            this.btn_OutputText.Name = "btn_OutputText";
            this.btn_OutputText.Size = new System.Drawing.Size(83, 45);
            this.btn_OutputText.TabIndex = 10;
            this.btn_OutputText.Text = "Text";
            this.btn_OutputText.UseVisualStyleBackColor = false;
            // 
            // grp_Settings
            // 
            this.grp_Settings.Controls.Add(this.cBox_AspectRatio);
            this.grp_Settings.Controls.Add(this.lbl_Height);
            this.grp_Settings.Controls.Add(this.lbl_Width);
            this.grp_Settings.Controls.Add(this.txt_Height);
            this.grp_Settings.Controls.Add(this.txt_FontFamily);
            this.grp_Settings.Controls.Add(this.txt_Width);
            this.grp_Settings.Controls.Add(this.txt_FontSize);
            this.grp_Settings.Controls.Add(this.lbl_SizeSettings);
            this.grp_Settings.Controls.Add(this.lbl_FontSettings);
            this.grp_Settings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Settings.ForeColor = System.Drawing.Color.Silver;
            this.grp_Settings.Location = new System.Drawing.Point(133, 370);
            this.grp_Settings.Name = "grp_Settings";
            this.grp_Settings.Size = new System.Drawing.Size(178, 113);
            this.grp_Settings.TabIndex = 24;
            this.grp_Settings.TabStop = false;
            this.grp_Settings.Text = "SETTINGS";
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Height.Location = new System.Drawing.Point(109, 60);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(16, 16);
            this.lbl_Height.TabIndex = 27;
            this.lbl_Height.Text = "H";
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Width.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_Width.Location = new System.Drawing.Point(46, 61);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(19, 16);
            this.lbl_Width.TabIndex = 26;
            this.lbl_Width.Text = "W";
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_Height.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Height.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Height.Location = new System.Drawing.Point(128, 55);
            this.txt_Height.MaxLength = 6;
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(38, 21);
            this.txt_Height.TabIndex = 7;
            // 
            // txt_FontFamily
            // 
            this.txt_FontFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_FontFamily.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FontFamily.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_FontFamily.Location = new System.Drawing.Point(97, 24);
            this.txt_FontFamily.Name = "txt_FontFamily";
            this.txt_FontFamily.Size = new System.Drawing.Size(69, 21);
            this.txt_FontFamily.TabIndex = 6;
            // 
            // txt_Width
            // 
            this.txt_Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_Width.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Width.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Width.Location = new System.Drawing.Point(66, 56);
            this.txt_Width.MaxLength = 6;
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(40, 21);
            this.txt_Width.TabIndex = 4;
            // 
            // txt_FontSize
            // 
            this.txt_FontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_FontSize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FontSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_FontSize.Location = new System.Drawing.Point(51, 24);
            this.txt_FontSize.MaxLength = 6;
            this.txt_FontSize.Name = "txt_FontSize";
            this.txt_FontSize.Size = new System.Drawing.Size(34, 21);
            this.txt_FontSize.TabIndex = 3;
            // 
            // lbl_SizeSettings
            // 
            this.lbl_SizeSettings.AutoSize = true;
            this.lbl_SizeSettings.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_SizeSettings.Location = new System.Drawing.Point(5, 60);
            this.lbl_SizeSettings.Name = "lbl_SizeSettings";
            this.lbl_SizeSettings.Size = new System.Drawing.Size(29, 16);
            this.lbl_SizeSettings.TabIndex = 1;
            this.lbl_SizeSettings.Text = "SIZE";
            // 
            // lbl_FontSettings
            // 
            this.lbl_FontSettings.AutoSize = true;
            this.lbl_FontSettings.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FontSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_FontSettings.Location = new System.Drawing.Point(6, 28);
            this.lbl_FontSettings.Name = "lbl_FontSettings";
            this.lbl_FontSettings.Size = new System.Drawing.Size(36, 16);
            this.lbl_FontSettings.TabIndex = 0;
            this.lbl_FontSettings.Text = "FONT";
            // 
            // lbl_ContrastDefault
            // 
            this.lbl_ContrastDefault.AutoSize = true;
            this.lbl_ContrastDefault.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContrastDefault.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ContrastDefault.Location = new System.Drawing.Point(152, 334);
            this.lbl_ContrastDefault.Name = "lbl_ContrastDefault";
            this.lbl_ContrastDefault.Size = new System.Drawing.Size(14, 16);
            this.lbl_ContrastDefault.TabIndex = 25;
            this.lbl_ContrastDefault.Text = "0";
            // 
            // lbl_ContrastMaximum
            // 
            this.lbl_ContrastMaximum.AutoSize = true;
            this.lbl_ContrastMaximum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContrastMaximum.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ContrastMaximum.Location = new System.Drawing.Point(256, 334);
            this.lbl_ContrastMaximum.Name = "lbl_ContrastMaximum";
            this.lbl_ContrastMaximum.Size = new System.Drawing.Size(26, 16);
            this.lbl_ContrastMaximum.TabIndex = 23;
            this.lbl_ContrastMaximum.Text = "100";
            // 
            // lbl_ContrastMinimum
            // 
            this.lbl_ContrastMinimum.AutoSize = true;
            this.lbl_ContrastMinimum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ContrastMinimum.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_ContrastMinimum.Location = new System.Drawing.Point(31, 334);
            this.lbl_ContrastMinimum.Name = "lbl_ContrastMinimum";
            this.lbl_ContrastMinimum.Size = new System.Drawing.Size(30, 16);
            this.lbl_ContrastMinimum.TabIndex = 22;
            this.lbl_ContrastMinimum.Text = "-100";
            // 
            // slider_Contrast
            // 
            this.slider_Contrast.Location = new System.Drawing.Point(31, 302);
            this.slider_Contrast.Minimum = -10;
            this.slider_Contrast.Name = "slider_Contrast";
            this.slider_Contrast.Size = new System.Drawing.Size(250, 45);
            this.slider_Contrast.TabIndex = 21;
            // 
            // pBox_Output
            // 
            this.pBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Output.Location = new System.Drawing.Point(48, 56);
            this.pBox_Output.Name = "pBox_Output";
            this.pBox_Output.Size = new System.Drawing.Size(565, 531);
            this.pBox_Output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Output.TabIndex = 27;
            this.pBox_Output.TabStop = false;
            // 
            // pBox_Input
            // 
            this.pBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Input.Location = new System.Drawing.Point(31, 30);
            this.pBox_Input.Name = "pBox_Input";
            this.pBox_Input.Size = new System.Drawing.Size(250, 250);
            this.pBox_Input.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Input.TabIndex = 20;
            this.pBox_Input.TabStop = false;
            // 
            // btn_SettingsCustom
            // 
            this.btn_SettingsCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SettingsCustom.FlatAppearance.BorderSize = 0;
            this.btn_SettingsCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsCustom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SettingsCustom.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_SettingsCustom.Image = ((System.Drawing.Image)(resources.GetObject("btn_SettingsCustom.Image")));
            this.btn_SettingsCustom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SettingsCustom.Location = new System.Drawing.Point(133, 608);
            this.btn_SettingsCustom.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SettingsCustom.Name = "btn_SettingsCustom";
            this.btn_SettingsCustom.Size = new System.Drawing.Size(178, 48);
            this.btn_SettingsCustom.TabIndex = 28;
            this.btn_SettingsCustom.Text = "        Custom";
            this.btn_SettingsCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SettingsCustom.UseVisualStyleBackColor = false;
            // 
            // btn_SettingsColored
            // 
            this.btn_SettingsColored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsColored.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SettingsColored.FlatAppearance.BorderSize = 0;
            this.btn_SettingsColored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsColored.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SettingsColored.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_SettingsColored.Image = ((System.Drawing.Image)(resources.GetObject("btn_SettingsColored.Image")));
            this.btn_SettingsColored.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SettingsColored.Location = new System.Drawing.Point(133, 554);
            this.btn_SettingsColored.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SettingsColored.Name = "btn_SettingsColored";
            this.btn_SettingsColored.Size = new System.Drawing.Size(178, 48);
            this.btn_SettingsColored.TabIndex = 27;
            this.btn_SettingsColored.Text = "        Colored";
            this.btn_SettingsColored.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SettingsColored.UseVisualStyleBackColor = false;
            // 
            // btn_SettingsGreyscaled
            // 
            this.btn_SettingsGreyscaled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsGreyscaled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SettingsGreyscaled.FlatAppearance.BorderSize = 0;
            this.btn_SettingsGreyscaled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsGreyscaled.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SettingsGreyscaled.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_SettingsGreyscaled.Image = ((System.Drawing.Image)(resources.GetObject("btn_SettingsGreyscaled.Image")));
            this.btn_SettingsGreyscaled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SettingsGreyscaled.Location = new System.Drawing.Point(133, 500);
            this.btn_SettingsGreyscaled.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SettingsGreyscaled.Name = "btn_SettingsGreyscaled";
            this.btn_SettingsGreyscaled.Size = new System.Drawing.Size(178, 48);
            this.btn_SettingsGreyscaled.TabIndex = 26;
            this.btn_SettingsGreyscaled.Text = "        Greyscale";
            this.btn_SettingsGreyscaled.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SettingsGreyscaled.UseVisualStyleBackColor = false;
            // 
            // pBox_Logo
            // 
            this.pBox_Logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Logo.Location = new System.Drawing.Point(27, 377);
            this.pBox_Logo.Name = "pBox_Logo";
            this.pBox_Logo.Size = new System.Drawing.Size(90, 279);
            this.pBox_Logo.TabIndex = 28;
            this.pBox_Logo.TabStop = false;
            // 
            // cBox_AspectRatio
            // 
            this.cBox_AspectRatio.AutoSize = true;
            this.cBox_AspectRatio.Location = new System.Drawing.Point(9, 86);
            this.cBox_AspectRatio.Name = "cBox_AspectRatio";
            this.cBox_AspectRatio.Size = new System.Drawing.Size(138, 21);
            this.cBox_AspectRatio.TabIndex = 28;
            this.cBox_AspectRatio.Text = "Keep Aspect Ratio";
            this.cBox_AspectRatio.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.pBox_Logo);
            this.Controls.Add(this.btn_SettingsCustom);
            this.Controls.Add(this.btn_SettingsColored);
            this.Controls.Add(this.btn_SettingsGreyscaled);
            this.Controls.Add(this.lbl_ContrastDefault);
            this.Controls.Add(this.lbl_ContrastMinimum);
            this.Controls.Add(this.lbl_ContrastMaximum);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.grp_Settings);
            this.Controls.Add(this.pBox_Input);
            this.Controls.Add(this.slider_Contrast);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            this.panel_Top.ResumeLayout(false);
            this.grp_Output.ResumeLayout(false);
            this.grp_Settings.ResumeLayout(false);
            this.grp_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.Button btn_OutputHTML;
        private System.Windows.Forms.Button btn_OutputImage;
        private System.Windows.Forms.Button btn_OutputText;
        private System.Windows.Forms.GroupBox grp_Settings;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_FontFamily;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.TextBox txt_FontSize;
        private System.Windows.Forms.Label lbl_SizeSettings;
        private System.Windows.Forms.Label lbl_FontSettings;
        private System.Windows.Forms.Label lbl_ContrastDefault;
        private System.Windows.Forms.Label lbl_ContrastMaximum;
        private System.Windows.Forms.Label lbl_ContrastMinimum;
        private System.Windows.Forms.TrackBar slider_Contrast;
        private System.Windows.Forms.PictureBox pBox_Input;
        private System.Windows.Forms.Label lbl_Log;
        private System.Windows.Forms.PictureBox pBox_Output;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.Button btn_SettingsCustom;
        private System.Windows.Forms.Button btn_SettingsColored;
        private System.Windows.Forms.Button btn_SettingsGreyscaled;
        private System.Windows.Forms.PictureBox pBox_Logo;
        private System.Windows.Forms.CheckBox cBox_AspectRatio;
    }
}

