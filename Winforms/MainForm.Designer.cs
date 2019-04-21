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
            this.panel_Left = new System.Windows.Forms.Panel();
            this.grp_Output = new System.Windows.Forms.GroupBox();
            this.grp_Settings = new System.Windows.Forms.GroupBox();
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
            this.pBox_Input = new System.Windows.Forms.PictureBox();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.pBox_Output = new System.Windows.Forms.PictureBox();
            this.text_SaveDestination = new System.Windows.Forms.TextBox();
            this.btn_OutputText = new System.Windows.Forms.Button();
            this.btn_OutputImage = new System.Windows.Forms.Button();
            this.btn_OutputHTML = new System.Windows.Forms.Button();
            this.btn_SettingsCustom = new System.Windows.Forms.Button();
            this.btn_SettingsColored = new System.Windows.Forms.Button();
            this.btn_SettingsGreyscaled = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.panel_Left.SuspendLayout();
            this.grp_Output.SuspendLayout();
            this.grp_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).BeginInit();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Output)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.panel_Left.Controls.Add(this.grp_Output);
            this.panel_Left.Controls.Add(this.grp_Settings);
            this.panel_Left.Controls.Add(this.lbl_ContrastDefault);
            this.panel_Left.Controls.Add(this.lbl_ContrastMaximum);
            this.panel_Left.Controls.Add(this.lbl_ContrastMinimum);
            this.panel_Left.Controls.Add(this.slider_Contrast);
            this.panel_Left.Controls.Add(this.pBox_Input);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(339, 681);
            this.panel_Left.TabIndex = 0;
            // 
            // grp_Output
            // 
            this.grp_Output.Controls.Add(this.btn_OutputHTML);
            this.grp_Output.Controls.Add(this.btn_OutputImage);
            this.grp_Output.Controls.Add(this.btn_OutputText);
            this.grp_Output.Location = new System.Drawing.Point(37, 357);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(250, 85);
            this.grp_Output.TabIndex = 8;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "Output";
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
            this.grp_Settings.Location = new System.Drawing.Point(37, 466);
            this.grp_Settings.Name = "grp_Settings";
            this.grp_Settings.Size = new System.Drawing.Size(250, 181);
            this.grp_Settings.TabIndex = 4;
            this.grp_Settings.TabStop = false;
            this.grp_Settings.Text = "Settings";
            // 
            // txt_Height
            // 
            this.txt_Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_Height.Location = new System.Drawing.Point(148, 70);
            this.txt_Height.Name = "txt_Height";
            this.txt_Height.Size = new System.Drawing.Size(80, 20);
            this.txt_Height.TabIndex = 7;
            // 
            // txt_FontFamily
            // 
            this.txt_FontFamily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_FontFamily.Location = new System.Drawing.Point(130, 37);
            this.txt_FontFamily.Name = "txt_FontFamily";
            this.txt_FontFamily.Size = new System.Drawing.Size(98, 20);
            this.txt_FontFamily.TabIndex = 6;
            // 
            // txt_Width
            // 
            this.txt_Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_Width.Location = new System.Drawing.Point(48, 70);
            this.txt_Width.Name = "txt_Width";
            this.txt_Width.Size = new System.Drawing.Size(90, 20);
            this.txt_Width.TabIndex = 4;
            // 
            // txt_FontSize
            // 
            this.txt_FontSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.txt_FontSize.Location = new System.Drawing.Point(48, 37);
            this.txt_FontSize.Name = "txt_FontSize";
            this.txt_FontSize.Size = new System.Drawing.Size(66, 20);
            this.txt_FontSize.TabIndex = 3;
            // 
            // lbl_SizeSettings
            // 
            this.lbl_SizeSettings.AutoSize = true;
            this.lbl_SizeSettings.Location = new System.Drawing.Point(7, 74);
            this.lbl_SizeSettings.Name = "lbl_SizeSettings";
            this.lbl_SizeSettings.Size = new System.Drawing.Size(27, 13);
            this.lbl_SizeSettings.TabIndex = 1;
            this.lbl_SizeSettings.Text = "Size";
            // 
            // lbl_FontSettings
            // 
            this.lbl_FontSettings.AutoSize = true;
            this.lbl_FontSettings.Location = new System.Drawing.Point(7, 41);
            this.lbl_FontSettings.Name = "lbl_FontSettings";
            this.lbl_FontSettings.Size = new System.Drawing.Size(28, 13);
            this.lbl_FontSettings.TabIndex = 0;
            this.lbl_FontSettings.Text = "Font";
            // 
            // lbl_ContrastDefault
            // 
            this.lbl_ContrastDefault.AutoSize = true;
            this.lbl_ContrastDefault.Location = new System.Drawing.Point(158, 332);
            this.lbl_ContrastDefault.Name = "lbl_ContrastDefault";
            this.lbl_ContrastDefault.Size = new System.Drawing.Size(13, 13);
            this.lbl_ContrastDefault.TabIndex = 4;
            this.lbl_ContrastDefault.Text = "0";
            // 
            // lbl_ContrastMaximum
            // 
            this.lbl_ContrastMaximum.AutoSize = true;
            this.lbl_ContrastMaximum.Location = new System.Drawing.Point(262, 332);
            this.lbl_ContrastMaximum.Name = "lbl_ContrastMaximum";
            this.lbl_ContrastMaximum.Size = new System.Drawing.Size(25, 13);
            this.lbl_ContrastMaximum.TabIndex = 3;
            this.lbl_ContrastMaximum.Text = "100";
            // 
            // lbl_ContrastMinimum
            // 
            this.lbl_ContrastMinimum.AutoSize = true;
            this.lbl_ContrastMinimum.Location = new System.Drawing.Point(37, 332);
            this.lbl_ContrastMinimum.Name = "lbl_ContrastMinimum";
            this.lbl_ContrastMinimum.Size = new System.Drawing.Size(28, 13);
            this.lbl_ContrastMinimum.TabIndex = 2;
            this.lbl_ContrastMinimum.Text = "-100";
            // 
            // slider_Contrast
            // 
            this.slider_Contrast.Location = new System.Drawing.Point(37, 300);
            this.slider_Contrast.Name = "slider_Contrast";
            this.slider_Contrast.Size = new System.Drawing.Size(250, 45);
            this.slider_Contrast.TabIndex = 1;
            // 
            // pBox_Input
            // 
            this.pBox_Input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Input.Location = new System.Drawing.Point(37, 28);
            this.pBox_Input.Name = "pBox_Input";
            this.pBox_Input.Size = new System.Drawing.Size(250, 250);
            this.pBox_Input.TabIndex = 0;
            this.pBox_Input.TabStop = false;
            // 
            // panel_Right
            // 
            this.panel_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(44)))));
            this.panel_Right.Controls.Add(this.btn_Enter);
            this.panel_Right.Controls.Add(this.pBox_Output);
            this.panel_Right.Controls.Add(this.text_SaveDestination);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Right.Location = new System.Drawing.Point(339, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(691, 681);
            this.panel_Right.TabIndex = 1;
            // 
            // pBox_Output
            // 
            this.pBox_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Output.Location = new System.Drawing.Point(37, 38);
            this.pBox_Output.Name = "pBox_Output";
            this.pBox_Output.Size = new System.Drawing.Size(617, 533);
            this.pBox_Output.TabIndex = 7;
            this.pBox_Output.TabStop = false;
            // 
            // text_SaveDestination
            // 
            this.text_SaveDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(99)))));
            this.text_SaveDestination.Location = new System.Drawing.Point(37, 607);
            this.text_SaveDestination.Name = "text_SaveDestination";
            this.text_SaveDestination.ReadOnly = true;
            this.text_SaveDestination.Size = new System.Drawing.Size(491, 20);
            this.text_SaveDestination.TabIndex = 8;
            this.text_SaveDestination.TabStop = false;
            // 
            // btn_OutputText
            // 
            this.btn_OutputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_OutputText.FlatAppearance.BorderSize = 0;
            this.btn_OutputText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutputText.Location = new System.Drawing.Point(22, 19);
            this.btn_OutputText.Name = "btn_OutputText";
            this.btn_OutputText.Size = new System.Drawing.Size(50, 50);
            this.btn_OutputText.TabIndex = 10;
            this.btn_OutputText.UseVisualStyleBackColor = false;
            // 
            // btn_OutputImage
            // 
            this.btn_OutputImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_OutputImage.FlatAppearance.BorderSize = 0;
            this.btn_OutputImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutputImage.Location = new System.Drawing.Point(99, 19);
            this.btn_OutputImage.Name = "btn_OutputImage";
            this.btn_OutputImage.Size = new System.Drawing.Size(50, 50);
            this.btn_OutputImage.TabIndex = 11;
            this.btn_OutputImage.UseVisualStyleBackColor = false;
            // 
            // btn_OutputHTML
            // 
            this.btn_OutputHTML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_OutputHTML.FlatAppearance.BorderSize = 0;
            this.btn_OutputHTML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutputHTML.Location = new System.Drawing.Point(178, 19);
            this.btn_OutputHTML.Name = "btn_OutputHTML";
            this.btn_OutputHTML.Size = new System.Drawing.Size(50, 50);
            this.btn_OutputHTML.TabIndex = 12;
            this.btn_OutputHTML.UseVisualStyleBackColor = false;
            // 
            // btn_SettingsCustom
            // 
            this.btn_SettingsCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsCustom.FlatAppearance.BorderSize = 0;
            this.btn_SettingsCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsCustom.Location = new System.Drawing.Point(178, 111);
            this.btn_SettingsCustom.Name = "btn_SettingsCustom";
            this.btn_SettingsCustom.Size = new System.Drawing.Size(50, 50);
            this.btn_SettingsCustom.TabIndex = 15;
            this.btn_SettingsCustom.UseVisualStyleBackColor = false;
            // 
            // btn_SettingsColored
            // 
            this.btn_SettingsColored.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsColored.FlatAppearance.BorderSize = 0;
            this.btn_SettingsColored.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsColored.Location = new System.Drawing.Point(99, 111);
            this.btn_SettingsColored.Name = "btn_SettingsColored";
            this.btn_SettingsColored.Size = new System.Drawing.Size(50, 50);
            this.btn_SettingsColored.TabIndex = 14;
            this.btn_SettingsColored.UseVisualStyleBackColor = false;
            // 
            // btn_SettingsGreyscaled
            // 
            this.btn_SettingsGreyscaled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_SettingsGreyscaled.FlatAppearance.BorderSize = 0;
            this.btn_SettingsGreyscaled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SettingsGreyscaled.Location = new System.Drawing.Point(22, 111);
            this.btn_SettingsGreyscaled.Name = "btn_SettingsGreyscaled";
            this.btn_SettingsGreyscaled.Size = new System.Drawing.Size(50, 50);
            this.btn_SettingsGreyscaled.TabIndex = 13;
            this.btn_SettingsGreyscaled.UseVisualStyleBackColor = false;
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.btn_Enter.FlatAppearance.BorderSize = 0;
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Location = new System.Drawing.Point(545, 591);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(109, 56);
            this.btn_Enter.TabIndex = 16;
            this.btn_Enter.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1030, 681);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Left.ResumeLayout(false);
            this.panel_Left.PerformLayout();
            this.grp_Output.ResumeLayout(false);
            this.grp_Settings.ResumeLayout(false);
            this.grp_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).EndInit();
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Output)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.Label lbl_ContrastDefault;
        private System.Windows.Forms.Label lbl_ContrastMaximum;
        private System.Windows.Forms.Label lbl_ContrastMinimum;
        private System.Windows.Forms.TrackBar slider_Contrast;
        private System.Windows.Forms.PictureBox pBox_Input;
        private System.Windows.Forms.GroupBox grp_Settings;
        private System.Windows.Forms.TextBox txt_Height;
        private System.Windows.Forms.TextBox txt_FontFamily;
        private System.Windows.Forms.TextBox txt_Width;
        private System.Windows.Forms.TextBox txt_FontSize;
        private System.Windows.Forms.Label lbl_SizeSettings;
        private System.Windows.Forms.Label lbl_FontSettings;
        private System.Windows.Forms.GroupBox grp_Output;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.PictureBox pBox_Output;
        private System.Windows.Forms.TextBox text_SaveDestination;
        private System.Windows.Forms.Button btn_OutputHTML;
        private System.Windows.Forms.Button btn_OutputImage;
        private System.Windows.Forms.Button btn_OutputText;
        private System.Windows.Forms.Button btn_SettingsCustom;
        private System.Windows.Forms.Button btn_SettingsColored;
        private System.Windows.Forms.Button btn_SettingsGreyscaled;
        private System.Windows.Forms.Button btn_Enter;
    }
}

