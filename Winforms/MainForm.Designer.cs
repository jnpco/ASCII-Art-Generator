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
            this.pBox_HMTL = new System.Windows.Forms.PictureBox();
            this.pBox_Image = new System.Windows.Forms.PictureBox();
            this.pBox_Text = new System.Windows.Forms.PictureBox();
            this.grp_Settings = new System.Windows.Forms.GroupBox();
            this.pBox_CSettingCustom = new System.Windows.Forms.PictureBox();
            this.pBox_CSettingColored = new System.Windows.Forms.PictureBox();
            this.pBox_CSettingGrayscale = new System.Windows.Forms.PictureBox();
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
            this.pBox_Enter = new System.Windows.Forms.PictureBox();
            this.pBox_Output = new System.Windows.Forms.PictureBox();
            this.text_SaveDestination = new System.Windows.Forms.TextBox();
            this.panel_Left.SuspendLayout();
            this.grp_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_HMTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Text)).BeginInit();
            this.grp_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CSettingCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CSettingColored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CSettingGrayscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).BeginInit();
            this.panel_Right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Enter)).BeginInit();
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
            this.grp_Output.Controls.Add(this.pBox_HMTL);
            this.grp_Output.Controls.Add(this.pBox_Image);
            this.grp_Output.Controls.Add(this.pBox_Text);
            this.grp_Output.Location = new System.Drawing.Point(37, 357);
            this.grp_Output.Name = "grp_Output";
            this.grp_Output.Size = new System.Drawing.Size(250, 85);
            this.grp_Output.TabIndex = 8;
            this.grp_Output.TabStop = false;
            this.grp_Output.Text = "Output";
            this.grp_Output.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pBox_HMTL
            // 
            this.pBox_HMTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_HMTL.Location = new System.Drawing.Point(178, 19);
            this.pBox_HMTL.Name = "pBox_HMTL";
            this.pBox_HMTL.Size = new System.Drawing.Size(50, 50);
            this.pBox_HMTL.TabIndex = 2;
            this.pBox_HMTL.TabStop = false;
            // 
            // pBox_Image
            // 
            this.pBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Image.Location = new System.Drawing.Point(99, 19);
            this.pBox_Image.Name = "pBox_Image";
            this.pBox_Image.Size = new System.Drawing.Size(50, 50);
            this.pBox_Image.TabIndex = 1;
            this.pBox_Image.TabStop = false;
            // 
            // pBox_Text
            // 
            this.pBox_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Text.Location = new System.Drawing.Point(22, 19);
            this.pBox_Text.Name = "pBox_Text";
            this.pBox_Text.Size = new System.Drawing.Size(50, 50);
            this.pBox_Text.TabIndex = 0;
            this.pBox_Text.TabStop = false;
            // 
            // grp_Settings
            // 
            this.grp_Settings.Controls.Add(this.pBox_CSettingCustom);
            this.grp_Settings.Controls.Add(this.pBox_CSettingColored);
            this.grp_Settings.Controls.Add(this.pBox_CSettingGrayscale);
            this.grp_Settings.Controls.Add(this.txt_Height);
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
            // pBox_CSettingCustom
            // 
            this.pBox_CSettingCustom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_CSettingCustom.Location = new System.Drawing.Point(178, 117);
            this.pBox_CSettingCustom.Name = "pBox_CSettingCustom";
            this.pBox_CSettingCustom.Size = new System.Drawing.Size(50, 50);
            this.pBox_CSettingCustom.TabIndex = 10;
            this.pBox_CSettingCustom.TabStop = false;
            // 
            // pBox_CSettingColored
            // 
            this.pBox_CSettingColored.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_CSettingColored.Location = new System.Drawing.Point(99, 117);
            this.pBox_CSettingColored.Name = "pBox_CSettingColored";
            this.pBox_CSettingColored.Size = new System.Drawing.Size(50, 50);
            this.pBox_CSettingColored.TabIndex = 9;
            this.pBox_CSettingColored.TabStop = false;
            // 
            // pBox_CSettingGrayscale
            // 
            this.pBox_CSettingGrayscale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_CSettingGrayscale.Location = new System.Drawing.Point(22, 117);
            this.pBox_CSettingGrayscale.Name = "pBox_CSettingGrayscale";
            this.pBox_CSettingGrayscale.Size = new System.Drawing.Size(50, 50);
            this.pBox_CSettingGrayscale.TabIndex = 8;
            this.pBox_CSettingGrayscale.TabStop = false;
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
            this.panel_Right.Controls.Add(this.pBox_Enter);
            this.panel_Right.Controls.Add(this.pBox_Output);
            this.panel_Right.Controls.Add(this.text_SaveDestination);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Right.Location = new System.Drawing.Point(339, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(691, 681);
            this.panel_Right.TabIndex = 1;
            // 
            // pBox_Enter
            // 
            this.pBox_Enter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Enter.Location = new System.Drawing.Point(554, 592);
            this.pBox_Enter.Name = "pBox_Enter";
            this.pBox_Enter.Size = new System.Drawing.Size(100, 50);
            this.pBox_Enter.TabIndex = 9;
            this.pBox_Enter.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pBox_HMTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Text)).EndInit();
            this.grp_Settings.ResumeLayout(false);
            this.grp_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CSettingCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CSettingColored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_CSettingGrayscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Input)).EndInit();
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Enter)).EndInit();
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
        private System.Windows.Forms.PictureBox pBox_HMTL;
        private System.Windows.Forms.PictureBox pBox_Image;
        private System.Windows.Forms.PictureBox pBox_Text;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.PictureBox pBox_Enter;
        private System.Windows.Forms.PictureBox pBox_Output;
        private System.Windows.Forms.TextBox text_SaveDestination;
        private System.Windows.Forms.PictureBox pBox_CSettingCustom;
        private System.Windows.Forms.PictureBox pBox_CSettingColored;
        private System.Windows.Forms.PictureBox pBox_CSettingGrayscale;
    }
}

