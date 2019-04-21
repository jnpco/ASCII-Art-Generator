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
            this.panel_Right = new System.Windows.Forms.Panel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.pBox_Output = new System.Windows.Forms.PictureBox();
            this.text_SaveDestination = new System.Windows.Forms.TextBox();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.btn_OutputHTML = new System.Windows.Forms.Button();
            this.btn_OutputImage = new System.Windows.Forms.Button();
            this.btn_OutputText = new System.Windows.Forms.Button();
            this.grp_Settings = new System.Windows.Forms.GroupBox();
            this.btn_SettingsCustom = new System.Windows.Forms.Button();
            this.txt_Height = new System.Windows.Forms.TextBox();
            this.btn_SettingsColored = new System.Windows.Forms.Button();
            this.btn_SettingsGreyscaled = new System.Windows.Forms.Button();
            this.txt_FontFamily = new System.Windows.Forms.TextBox();
            this.txt_Width = new System.Windows.Forms.TextBox();
            this.txt_FontSize = new System.Windows.Forms.TextBox();
            this.lbl_SizeSettings = new System.Windows.Forms.Label();
            this.lbl_FontSettings = new System.Windows.Forms.Label();
            this.lbl_ContrastDefault = new System.Windows.Forms.Label();
            this.lbl_ContrastMaximum = new System.Windows.Forms.Label();
            this.lbl_ContrastMinimum = new System.Windows.Forms.Label();
            this.slider_Contrast = new System.Windows.Forms.TrackBar();
            this.pBox_Input = new System.Windows.Forms.PictureBox();
            this.panel_Right.SuspendLayout();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Output)).BeginInit();
            this.grp_Output.SuspendLayout();
            this.grp_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.panel_Right.Controls.Add(this.panel_Top);
            this.panel_Right.Controls.Add(this.btn_Enter);
            this.panel_Right.Controls.Add(this.pBox_Output);
            this.panel_Right.Controls.Add(this.text_SaveDestination);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(309, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(660, 681);
            this.panel_Right.TabIndex = 7;
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
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_Enter.Location = new System.Drawing.Point(501, 605);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(109, 49);
            this.btn_Enter.TabIndex = 16;
            this.btn_Enter.UseVisualStyleBackColor = false;
            // 
            // pBox_Output
            // 
            this.pBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Output.Location = new System.Drawing.Point(45, 64);
            this.pBox_Output.Name = "pBox_Output";
            this.pBox_Output.Size = new System.Drawing.Size(565, 531);
            this.pBox_Output.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_Output.TabIndex = 7;
            this.pBox_Output.TabStop = false;
            // 
            // text_SaveDestination
            // 
            this.text_SaveDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.text_SaveDestination.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_SaveDestination.ForeColor = System.Drawing.Color.DarkGray;
            this.text_SaveDestination.Location = new System.Drawing.Point(45, 620);
            this.text_SaveDestination.Name = "text_SaveDestination";
            this.text_SaveDestination.ReadOnly = true;
            this.text_SaveDestination.Size = new System.Drawing.Size(449, 22);
            this.text_SaveDestination.TabIndex = 8;
            this.text_SaveDestination.TabStop = false;
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.btn_OutputHTML);
            this.grp_Output.Controls.Add(this.btn_OutputImage);
            this.grp_Output.Controls.Add(this.btn_OutputText);
            this.grp_Output.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Output.ForeColor = System.Drawing.Color.DarkGray;
            this.grp_Output.Location = new System.Drawing.Point(31, 353);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(250, 91);
            this.grp_Output.TabIndex = 26;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "OUTPUT";
            // 
            // btn_OutputHTML
            // 
            this.btn_OutputHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_OutputHTML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_OutputHTML.FlatAppearance.BorderSize = 0;
            this.btn_OutputHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutputHTML.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OutputHTML.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_OutputHTML.Location = new System.Drawing.Point(170, 23);
            this.btn_OutputHTML.Name = "btn_OutputHTML";
            this.btn_OutputHTML.Size = new System.Drawing.Size(67, 50);
            this.btn_OutputHTML.TabIndex = 12;
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
            this.btn_OutputImage.Location = new System.Drawing.Point(92, 23);
            this.btn_OutputImage.Name = "btn_OutputImage";
            this.btn_OutputImage.Size = new System.Drawing.Size(67, 50);
            this.btn_OutputImage.TabIndex = 11;
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
            this.btn_OutputText.Location = new System.Drawing.Point(14, 23);
            this.btn_OutputText.Name = "btn_OutputText";
            this.btn_OutputText.Size = new System.Drawing.Size(67, 50);
            this.btn_OutputText.TabIndex = 10;
            this.btn_OutputText.UseVisualStyleBackColor = false;
            // 
            // grp_Settings
            // 
            this.grp_Settings.Controls.Add(this.btn_SettingsCustom);
            this.grp_Settings.Controls.Add(this.txt_Height);
            this.grp_Settings.Controls.Add(this.btn_SettingsColored);
            this.grp_Settings.Controls.Add(this.btn_SettingsGreyscaled);
            this.grp_Settings.Controls.Add(this.txt_FontFamily);
            this.grp_Settings.Controls.Add(this.txt_Width);
            this.grp_Settings.Controls.Add(this.txt_FontSize);
            this.grp_Settings.Controls.Add(this.lbl_SizeSettings);
            this.grp_Settings.Controls.Add(this.lbl_FontSettings);
            this.grp_Settings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Settings.ForeColor = System.Drawing.Color.Silver;
            this.grp_Settings.Location = new System.Drawing.Point(31, 468);
            this.grp_Settings.Name = "grp_Settings";
            this.grp_Settings.Size = new System.Drawing.Size(250, 181);
            this.grp_Settings.TabIndex = 24;
            this.grp_Settings.TabStop = false;
            this.grp_Settings.Text = "SETTINGS";
            // 
            // btn_SettingsCustom
            // 
            this.btn_SettingsCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SettingsCustom.FlatAppearance.BorderSize = 0;
            this.btn_SettingsCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsCustom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SettingsCustom.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_SettingsCustom.Location = new System.Drawing.Point(170, 111);
            this.btn_SettingsCustom.Name = "btn_SettingsCustom";
            this.btn_SettingsCustom.Size = new System.Drawing.Size(67, 50);
            this.btn_SettingsCustom.TabIndex = 15;
            this.btn_SettingsCustom.UseVisualStyleBackColor = false;
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_Height.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Height.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Height.Location = new System.Drawing.Point(143, 70);
            this.txt_Height.MaxLength = 6;
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(85, 21);
            this.txt_Height.TabIndex = 7;
            // 
            // btn_SettingsColored
            // 
            this.btn_SettingsColored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsColored.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SettingsColored.FlatAppearance.BorderSize = 0;
            this.btn_SettingsColored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsColored.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SettingsColored.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_SettingsColored.Location = new System.Drawing.Point(92, 111);
            this.btn_SettingsColored.Name = "btn_SettingsColored";
            this.btn_SettingsColored.Size = new System.Drawing.Size(67, 50);
            this.btn_SettingsColored.TabIndex = 14;
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
            this.btn_SettingsGreyscaled.Location = new System.Drawing.Point(14, 111);
            this.btn_SettingsGreyscaled.Name = "btn_SettingsGreyscaled";
            this.btn_SettingsGreyscaled.Size = new System.Drawing.Size(67, 50);
            this.btn_SettingsGreyscaled.TabIndex = 13;
            this.btn_SettingsGreyscaled.UseVisualStyleBackColor = false;
            // 
            // txt_FontFamily
            // 
            this.txt_FontFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_FontFamily.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FontFamily.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_FontFamily.Location = new System.Drawing.Point(130, 37);
            this.txt_FontFamily.Name = "txt_FontFamily";
            this.txt_FontFamily.Size = new System.Drawing.Size(98, 21);
            this.txt_FontFamily.TabIndex = 6;
            // 
            // txt_Width
            // 
            this.txt_Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_Width.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Width.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Width.Location = new System.Drawing.Point(48, 70);
            this.txt_Width.MaxLength = 6;
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(85, 21);
            this.txt_Width.TabIndex = 4;
            // 
            // txt_FontSize
            // 
            this.txt_FontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_FontSize.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FontSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_FontSize.Location = new System.Drawing.Point(48, 37);
            this.txt_FontSize.MaxLength = 6;
            this.txt_FontSize.Name = "txt_FontSize";
            this.txt_FontSize.Size = new System.Drawing.Size(66, 21);
            this.txt_FontSize.TabIndex = 3;
            // 
            // lbl_SizeSettings
            // 
            this.lbl_SizeSettings.AutoSize = true;
            this.lbl_SizeSettings.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeSettings.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_SizeSettings.Location = new System.Drawing.Point(7, 74);
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
            this.lbl_FontSettings.Location = new System.Drawing.Point(7, 41);
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
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.lbl_ContrastDefault);
            this.Controls.Add(this.lbl_ContrastMinimum);
            this.Controls.Add(this.lbl_ContrastMaximum);
            this.Controls.Add(this.grp_Output);
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
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Output)).EndInit();
            this.grp_Output.ResumeLayout(false);
            this.grp_Settings.ResumeLayout(false);
            this.grp_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.PictureBox pBox_Output;
        private System.Windows.Forms.TextBox text_SaveDestination;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.Button btn_OutputHTML;
        private System.Windows.Forms.Button btn_OutputImage;
        private System.Windows.Forms.Button btn_OutputText;
        private System.Windows.Forms.GroupBox grp_Settings;
        private System.Windows.Forms.Button btn_SettingsCustom;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.Button btn_SettingsColored;
        private System.Windows.Forms.Button btn_SettingsGreyscaled;
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
    }
}

