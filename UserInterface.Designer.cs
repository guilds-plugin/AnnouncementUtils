namespace Announcements {
    partial class Announcements {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.uxVersionBox = new MetroFramework.Controls.MetroTextBox();
            this.uxUpdateTitleLabel = new MetroFramework.Controls.MetroLabel();
            this.uxUpdateTitleBox = new MetroFramework.Controls.MetroTextBox();
            this.uxConvert = new MetroFramework.Controls.MetroButton();
            this.uxClearButton = new MetroFramework.Controls.MetroButton();
            this.uxRawInput = new MetroFramework.Controls.MetroLabel();
            this.uxDiscordOuputLabel = new MetroFramework.Controls.MetroLabel();
            this.uxHTMLOutputLabel = new MetroFramework.Controls.MetroLabel();
            this.uxMySQLOutputLabel = new MetroFramework.Controls.MetroLabel();
            this.uxRawInputBox = new MetroFramework.Controls.MetroTextBox();
            this.uxDiscordOutputBox = new MetroFramework.Controls.MetroTextBox();
            this.uxHTMLOutputBox = new MetroFramework.Controls.MetroTextBox();
            this.uxMySQLOutputBox = new MetroFramework.Controls.MetroTextBox();
            this.uxOpenMenuButton = new MetroFramework.Controls.MetroButton();
            this.uxSaveAsMenuButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // uxVersionLabel
            // 
            this.uxVersionLabel.AutoSize = true;
            this.uxVersionLabel.Location = new System.Drawing.Point(23, 60);
            this.uxVersionLabel.Name = "uxVersionLabel";
            this.uxVersionLabel.Size = new System.Drawing.Size(147, 19);
            this.uxVersionLabel.TabIndex = 15;
            this.uxVersionLabel.Text = "What version is this for?";
            this.uxVersionLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // uxVersionBox
            // 
            // 
            // 
            // 
            this.uxVersionBox.CustomButton.Image = null;
            this.uxVersionBox.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.uxVersionBox.CustomButton.Name = "";
            this.uxVersionBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uxVersionBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxVersionBox.CustomButton.TabIndex = 1;
            this.uxVersionBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxVersionBox.CustomButton.UseSelectable = true;
            this.uxVersionBox.CustomButton.Visible = false;
            this.uxVersionBox.Lines = new string[0];
            this.uxVersionBox.Location = new System.Drawing.Point(23, 98);
            this.uxVersionBox.MaxLength = 32767;
            this.uxVersionBox.Multiline = true;
            this.uxVersionBox.Name = "uxVersionBox";
            this.uxVersionBox.PasswordChar = '\0';
            this.uxVersionBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxVersionBox.SelectedText = "";
            this.uxVersionBox.SelectionLength = 0;
            this.uxVersionBox.SelectionStart = 0;
            this.uxVersionBox.ShortcutsEnabled = true;
            this.uxVersionBox.Size = new System.Drawing.Size(147, 23);
            this.uxVersionBox.TabIndex = 16;
            this.uxVersionBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxVersionBox.UseSelectable = true;
            this.uxVersionBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxVersionBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxUpdateTitleLabel
            // 
            this.uxUpdateTitleLabel.AutoSize = true;
            this.uxUpdateTitleLabel.Location = new System.Drawing.Point(253, 60);
            this.uxUpdateTitleLabel.Name = "uxUpdateTitleLabel";
            this.uxUpdateTitleLabel.Size = new System.Drawing.Size(194, 19);
            this.uxUpdateTitleLabel.TabIndex = 17;
            this.uxUpdateTitleLabel.Text = "What is the title for this update?";
            this.uxUpdateTitleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // uxUpdateTitleBox
            // 
            // 
            // 
            // 
            this.uxUpdateTitleBox.CustomButton.Image = null;
            this.uxUpdateTitleBox.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.uxUpdateTitleBox.CustomButton.Name = "";
            this.uxUpdateTitleBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uxUpdateTitleBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxUpdateTitleBox.CustomButton.TabIndex = 1;
            this.uxUpdateTitleBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxUpdateTitleBox.CustomButton.UseSelectable = true;
            this.uxUpdateTitleBox.CustomButton.Visible = false;
            this.uxUpdateTitleBox.Lines = new string[0];
            this.uxUpdateTitleBox.Location = new System.Drawing.Point(253, 98);
            this.uxUpdateTitleBox.MaxLength = 32767;
            this.uxUpdateTitleBox.Name = "uxUpdateTitleBox";
            this.uxUpdateTitleBox.PasswordChar = '\0';
            this.uxUpdateTitleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxUpdateTitleBox.SelectedText = "";
            this.uxUpdateTitleBox.SelectionLength = 0;
            this.uxUpdateTitleBox.SelectionStart = 0;
            this.uxUpdateTitleBox.ShortcutsEnabled = true;
            this.uxUpdateTitleBox.Size = new System.Drawing.Size(194, 23);
            this.uxUpdateTitleBox.TabIndex = 18;
            this.uxUpdateTitleBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxUpdateTitleBox.UseSelectable = true;
            this.uxUpdateTitleBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxUpdateTitleBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxConvert
            // 
            this.uxConvert.Location = new System.Drawing.Point(533, 33);
            this.uxConvert.Name = "uxConvert";
            this.uxConvert.Size = new System.Drawing.Size(446, 85);
            this.uxConvert.TabIndex = 19;
            this.uxConvert.Text = "Convert";
            this.uxConvert.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxConvert.UseSelectable = true;
            this.uxConvert.Click += new System.EventHandler(this.UxConvert_Click);
            // 
            // uxClearButton
            // 
            this.uxClearButton.Location = new System.Drawing.Point(1014, 33);
            this.uxClearButton.Name = "uxClearButton";
            this.uxClearButton.Size = new System.Drawing.Size(446, 85);
            this.uxClearButton.TabIndex = 20;
            this.uxClearButton.Text = "Clear";
            this.uxClearButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxClearButton.UseSelectable = true;
            this.uxClearButton.Click += new System.EventHandler(this.UxClearButton_Click);
            // 
            // uxRawInput
            // 
            this.uxRawInput.AutoSize = true;
            this.uxRawInput.Location = new System.Drawing.Point(134, 161);
            this.uxRawInput.Name = "uxRawInput";
            this.uxRawInput.Size = new System.Drawing.Size(102, 19);
            this.uxRawInput.TabIndex = 21;
            this.uxRawInput.Text = "Insert Text Here:";
            this.uxRawInput.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // uxDiscordOuputLabel
            // 
            this.uxDiscordOuputLabel.AutoSize = true;
            this.uxDiscordOuputLabel.Location = new System.Drawing.Point(617, 161);
            this.uxDiscordOuputLabel.Name = "uxDiscordOuputLabel";
            this.uxDiscordOuputLabel.Size = new System.Drawing.Size(101, 19);
            this.uxDiscordOuputLabel.TabIndex = 22;
            this.uxDiscordOuputLabel.Text = "Discord Output:";
            this.uxDiscordOuputLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // uxHTMLOutputLabel
            // 
            this.uxHTMLOutputLabel.AutoSize = true;
            this.uxHTMLOutputLabel.Location = new System.Drawing.Point(1061, 161);
            this.uxHTMLOutputLabel.Name = "uxHTMLOutputLabel";
            this.uxHTMLOutputLabel.Size = new System.Drawing.Size(91, 19);
            this.uxHTMLOutputLabel.TabIndex = 23;
            this.uxHTMLOutputLabel.Text = "HTML Output:";
            this.uxHTMLOutputLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // uxMySQLOutputLabel
            // 
            this.uxMySQLOutputLabel.AutoSize = true;
            this.uxMySQLOutputLabel.Location = new System.Drawing.Point(1518, 161);
            this.uxMySQLOutputLabel.Name = "uxMySQLOutputLabel";
            this.uxMySQLOutputLabel.Size = new System.Drawing.Size(99, 19);
            this.uxMySQLOutputLabel.TabIndex = 24;
            this.uxMySQLOutputLabel.Text = "MySQL Output:";
            this.uxMySQLOutputLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // uxRawInputBox
            // 
            // 
            // 
            // 
            this.uxRawInputBox.CustomButton.Image = null;
            this.uxRawInputBox.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.uxRawInputBox.CustomButton.Name = "";
            this.uxRawInputBox.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.uxRawInputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxRawInputBox.CustomButton.TabIndex = 1;
            this.uxRawInputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxRawInputBox.CustomButton.UseSelectable = true;
            this.uxRawInputBox.CustomButton.Visible = false;
            this.uxRawInputBox.Lines = new string[0];
            this.uxRawInputBox.Location = new System.Drawing.Point(23, 196);
            this.uxRawInputBox.MaxLength = 32767;
            this.uxRawInputBox.Multiline = true;
            this.uxRawInputBox.Name = "uxRawInputBox";
            this.uxRawInputBox.PasswordChar = '\0';
            this.uxRawInputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxRawInputBox.SelectedText = "";
            this.uxRawInputBox.SelectionLength = 0;
            this.uxRawInputBox.SelectionStart = 0;
            this.uxRawInputBox.ShortcutsEnabled = true;
            this.uxRawInputBox.Size = new System.Drawing.Size(404, 393);
            this.uxRawInputBox.TabIndex = 25;
            this.uxRawInputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxRawInputBox.UseSelectable = true;
            this.uxRawInputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxRawInputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxDiscordOutputBox
            // 
            // 
            // 
            // 
            this.uxDiscordOutputBox.CustomButton.Image = null;
            this.uxDiscordOutputBox.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.uxDiscordOutputBox.CustomButton.Name = "";
            this.uxDiscordOutputBox.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.uxDiscordOutputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxDiscordOutputBox.CustomButton.TabIndex = 1;
            this.uxDiscordOutputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxDiscordOutputBox.CustomButton.UseSelectable = true;
            this.uxDiscordOutputBox.CustomButton.Visible = false;
            this.uxDiscordOutputBox.Lines = new string[0];
            this.uxDiscordOutputBox.Location = new System.Drawing.Point(467, 196);
            this.uxDiscordOutputBox.MaxLength = 32767;
            this.uxDiscordOutputBox.Multiline = true;
            this.uxDiscordOutputBox.Name = "uxDiscordOutputBox";
            this.uxDiscordOutputBox.PasswordChar = '\0';
            this.uxDiscordOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxDiscordOutputBox.SelectedText = "";
            this.uxDiscordOutputBox.SelectionLength = 0;
            this.uxDiscordOutputBox.SelectionStart = 0;
            this.uxDiscordOutputBox.ShortcutsEnabled = true;
            this.uxDiscordOutputBox.Size = new System.Drawing.Size(404, 393);
            this.uxDiscordOutputBox.TabIndex = 26;
            this.uxDiscordOutputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxDiscordOutputBox.UseSelectable = true;
            this.uxDiscordOutputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxDiscordOutputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxHTMLOutputBox
            // 
            // 
            // 
            // 
            this.uxHTMLOutputBox.CustomButton.Image = null;
            this.uxHTMLOutputBox.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.uxHTMLOutputBox.CustomButton.Name = "";
            this.uxHTMLOutputBox.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.uxHTMLOutputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxHTMLOutputBox.CustomButton.TabIndex = 1;
            this.uxHTMLOutputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxHTMLOutputBox.CustomButton.UseSelectable = true;
            this.uxHTMLOutputBox.CustomButton.Visible = false;
            this.uxHTMLOutputBox.Lines = new string[0];
            this.uxHTMLOutputBox.Location = new System.Drawing.Point(905, 196);
            this.uxHTMLOutputBox.MaxLength = 32767;
            this.uxHTMLOutputBox.Multiline = true;
            this.uxHTMLOutputBox.Name = "uxHTMLOutputBox";
            this.uxHTMLOutputBox.PasswordChar = '\0';
            this.uxHTMLOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxHTMLOutputBox.SelectedText = "";
            this.uxHTMLOutputBox.SelectionLength = 0;
            this.uxHTMLOutputBox.SelectionStart = 0;
            this.uxHTMLOutputBox.ShortcutsEnabled = true;
            this.uxHTMLOutputBox.Size = new System.Drawing.Size(404, 393);
            this.uxHTMLOutputBox.TabIndex = 27;
            this.uxHTMLOutputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxHTMLOutputBox.UseSelectable = true;
            this.uxHTMLOutputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxHTMLOutputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxMySQLOutputBox
            // 
            // 
            // 
            // 
            this.uxMySQLOutputBox.CustomButton.Image = null;
            this.uxMySQLOutputBox.CustomButton.Location = new System.Drawing.Point(12, 1);
            this.uxMySQLOutputBox.CustomButton.Name = "";
            this.uxMySQLOutputBox.CustomButton.Size = new System.Drawing.Size(391, 391);
            this.uxMySQLOutputBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxMySQLOutputBox.CustomButton.TabIndex = 1;
            this.uxMySQLOutputBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxMySQLOutputBox.CustomButton.UseSelectable = true;
            this.uxMySQLOutputBox.CustomButton.Visible = false;
            this.uxMySQLOutputBox.Lines = new string[0];
            this.uxMySQLOutputBox.Location = new System.Drawing.Point(1351, 196);
            this.uxMySQLOutputBox.MaxLength = 32767;
            this.uxMySQLOutputBox.Multiline = true;
            this.uxMySQLOutputBox.Name = "uxMySQLOutputBox";
            this.uxMySQLOutputBox.PasswordChar = '\0';
            this.uxMySQLOutputBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxMySQLOutputBox.SelectedText = "";
            this.uxMySQLOutputBox.SelectionLength = 0;
            this.uxMySQLOutputBox.SelectionStart = 0;
            this.uxMySQLOutputBox.ShortcutsEnabled = true;
            this.uxMySQLOutputBox.Size = new System.Drawing.Size(404, 393);
            this.uxMySQLOutputBox.TabIndex = 28;
            this.uxMySQLOutputBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxMySQLOutputBox.UseSelectable = true;
            this.uxMySQLOutputBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxMySQLOutputBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxOpenMenuButton
            // 
            this.uxOpenMenuButton.Location = new System.Drawing.Point(1518, 33);
            this.uxOpenMenuButton.Name = "uxOpenMenuButton";
            this.uxOpenMenuButton.Size = new System.Drawing.Size(180, 37);
            this.uxOpenMenuButton.TabIndex = 29;
            this.uxOpenMenuButton.Text = "Open...";
            this.uxOpenMenuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxOpenMenuButton.UseSelectable = true;
            this.uxOpenMenuButton.Click += new System.EventHandler(this.UxOpenMenuButton_Click);
            // 
            // uxSaveAsMenuButton
            // 
            this.uxSaveAsMenuButton.Location = new System.Drawing.Point(1518, 81);
            this.uxSaveAsMenuButton.Name = "uxSaveAsMenuButton";
            this.uxSaveAsMenuButton.Size = new System.Drawing.Size(180, 37);
            this.uxSaveAsMenuButton.TabIndex = 30;
            this.uxSaveAsMenuButton.Text = "Save As...";
            this.uxSaveAsMenuButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.uxSaveAsMenuButton.UseSelectable = true;
            this.uxSaveAsMenuButton.Click += new System.EventHandler(this.UxSaveAsMenuButton_Click);
            // 
            // Announcements
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1813, 643);
            this.Controls.Add(this.uxSaveAsMenuButton);
            this.Controls.Add(this.uxOpenMenuButton);
            this.Controls.Add(this.uxMySQLOutputBox);
            this.Controls.Add(this.uxHTMLOutputBox);
            this.Controls.Add(this.uxDiscordOutputBox);
            this.Controls.Add(this.uxRawInputBox);
            this.Controls.Add(this.uxMySQLOutputLabel);
            this.Controls.Add(this.uxHTMLOutputLabel);
            this.Controls.Add(this.uxDiscordOuputLabel);
            this.Controls.Add(this.uxRawInput);
            this.Controls.Add(this.uxClearButton);
            this.Controls.Add(this.uxConvert);
            this.Controls.Add(this.uxUpdateTitleBox);
            this.Controls.Add(this.uxUpdateTitleLabel);
            this.Controls.Add(this.uxVersionBox);
            this.Controls.Add(this.uxVersionLabel);
            this.Name = "Announcements";
            this.Text = "Announcements";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private MetroFramework.Controls.MetroLabel uxVersionLabel;
        private MetroFramework.Controls.MetroTextBox uxVersionBox;
        private MetroFramework.Controls.MetroLabel uxUpdateTitleLabel;
        private MetroFramework.Controls.MetroTextBox uxUpdateTitleBox;
        private MetroFramework.Controls.MetroButton uxConvert;
        private MetroFramework.Controls.MetroButton uxClearButton;
        private MetroFramework.Controls.MetroLabel uxRawInput;
        private MetroFramework.Controls.MetroLabel uxDiscordOuputLabel;
        private MetroFramework.Controls.MetroLabel uxHTMLOutputLabel;
        private MetroFramework.Controls.MetroLabel uxMySQLOutputLabel;
        private MetroFramework.Controls.MetroTextBox uxRawInputBox;
        private MetroFramework.Controls.MetroTextBox uxDiscordOutputBox;
        private MetroFramework.Controls.MetroTextBox uxHTMLOutputBox;
        private MetroFramework.Controls.MetroTextBox uxMySQLOutputBox;
        private MetroFramework.Controls.MetroButton uxOpenMenuButton;
        private MetroFramework.Controls.MetroButton uxSaveAsMenuButton;
    }
}

