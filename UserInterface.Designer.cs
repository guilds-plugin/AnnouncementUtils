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
            this.uxVersionLabel = new System.Windows.Forms.Label();
            this.uxRawInput = new System.Windows.Forms.Label();
            this.uxDiscordOuputLabel = new System.Windows.Forms.Label();
            this.uxHTMLOutputLabel = new System.Windows.Forms.Label();
            this.uxVersionBox = new System.Windows.Forms.TextBox();
            this.uxRawInputBox = new System.Windows.Forms.TextBox();
            this.uxDiscordOutputBox = new System.Windows.Forms.TextBox();
            this.uxHTMLOutputBox = new System.Windows.Forms.TextBox();
            this.uxConvert = new System.Windows.Forms.Button();
            this.uxMySQLOutputBox = new System.Windows.Forms.TextBox();
            this.uxMySQLOutputLabel = new System.Windows.Forms.Label();
            this.uxUpdateTitleBox = new System.Windows.Forms.TextBox();
            this.uxUpdateTitleLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxClearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxVersionLabel
            // 
            this.uxVersionLabel.AutoSize = true;
            this.uxVersionLabel.Location = new System.Drawing.Point(12, 49);
            this.uxVersionLabel.Name = "uxVersionLabel";
            this.uxVersionLabel.Size = new System.Drawing.Size(120, 13);
            this.uxVersionLabel.TabIndex = 0;
            this.uxVersionLabel.Text = "What version is this for?";
            // 
            // uxRawInput
            // 
            this.uxRawInput.AutoSize = true;
            this.uxRawInput.Location = new System.Drawing.Point(124, 161);
            this.uxRawInput.Name = "uxRawInput";
            this.uxRawInput.Size = new System.Drawing.Size(86, 13);
            this.uxRawInput.TabIndex = 1;
            this.uxRawInput.Text = "Insert Text Here:";
            // 
            // uxDiscordOuputLabel
            // 
            this.uxDiscordOuputLabel.AutoSize = true;
            this.uxDiscordOuputLabel.Location = new System.Drawing.Point(601, 161);
            this.uxDiscordOuputLabel.Name = "uxDiscordOuputLabel";
            this.uxDiscordOuputLabel.Size = new System.Drawing.Size(81, 13);
            this.uxDiscordOuputLabel.TabIndex = 2;
            this.uxDiscordOuputLabel.Text = "Discord Output:";
            // 
            // uxHTMLOutputLabel
            // 
            this.uxHTMLOutputLabel.AutoSize = true;
            this.uxHTMLOutputLabel.Location = new System.Drawing.Point(1052, 161);
            this.uxHTMLOutputLabel.Name = "uxHTMLOutputLabel";
            this.uxHTMLOutputLabel.Size = new System.Drawing.Size(75, 13);
            this.uxHTMLOutputLabel.TabIndex = 3;
            this.uxHTMLOutputLabel.Text = "HTML Output:";
            // 
            // uxVersionBox
            // 
            this.uxVersionBox.Location = new System.Drawing.Point(15, 65);
            this.uxVersionBox.Name = "uxVersionBox";
            this.uxVersionBox.Size = new System.Drawing.Size(117, 20);
            this.uxVersionBox.TabIndex = 4;
            // 
            // uxRawInputBox
            // 
            this.uxRawInputBox.Location = new System.Drawing.Point(12, 196);
            this.uxRawInputBox.Multiline = true;
            this.uxRawInputBox.Name = "uxRawInputBox";
            this.uxRawInputBox.Size = new System.Drawing.Size(404, 393);
            this.uxRawInputBox.TabIndex = 5;
            // 
            // uxDiscordOutputBox
            // 
            this.uxDiscordOutputBox.Location = new System.Drawing.Point(458, 196);
            this.uxDiscordOutputBox.Multiline = true;
            this.uxDiscordOutputBox.Name = "uxDiscordOutputBox";
            this.uxDiscordOutputBox.Size = new System.Drawing.Size(404, 393);
            this.uxDiscordOutputBox.TabIndex = 6;
            // 
            // uxHTMLOutputBox
            // 
            this.uxHTMLOutputBox.Location = new System.Drawing.Point(904, 196);
            this.uxHTMLOutputBox.Multiline = true;
            this.uxHTMLOutputBox.Name = "uxHTMLOutputBox";
            this.uxHTMLOutputBox.Size = new System.Drawing.Size(404, 393);
            this.uxHTMLOutputBox.TabIndex = 7;
            // 
            // uxConvert
            // 
            this.uxConvert.Location = new System.Drawing.Point(401, 33);
            this.uxConvert.Name = "uxConvert";
            this.uxConvert.Size = new System.Drawing.Size(446, 82);
            this.uxConvert.TabIndex = 8;
            this.uxConvert.Text = "Convert";
            this.uxConvert.UseVisualStyleBackColor = true;
            this.uxConvert.Click += new System.EventHandler(this.UxConvert_Click);
            // 
            // uxMySQLOutputBox
            // 
            this.uxMySQLOutputBox.Location = new System.Drawing.Point(1355, 196);
            this.uxMySQLOutputBox.Multiline = true;
            this.uxMySQLOutputBox.Name = "uxMySQLOutputBox";
            this.uxMySQLOutputBox.Size = new System.Drawing.Size(404, 393);
            this.uxMySQLOutputBox.TabIndex = 10;
            // 
            // uxMySQLOutputLabel
            // 
            this.uxMySQLOutputLabel.AutoSize = true;
            this.uxMySQLOutputLabel.Location = new System.Drawing.Point(1503, 161);
            this.uxMySQLOutputLabel.Name = "uxMySQLOutputLabel";
            this.uxMySQLOutputLabel.Size = new System.Drawing.Size(80, 13);
            this.uxMySQLOutputLabel.TabIndex = 9;
            this.uxMySQLOutputLabel.Text = "MySQL Output:";
            // 
            // uxUpdateTitleBox
            // 
            this.uxUpdateTitleBox.Location = new System.Drawing.Point(158, 65);
            this.uxUpdateTitleBox.Name = "uxUpdateTitleBox";
            this.uxUpdateTitleBox.Size = new System.Drawing.Size(163, 20);
            this.uxUpdateTitleBox.TabIndex = 12;
            // 
            // uxUpdateTitleLabel
            // 
            this.uxUpdateTitleLabel.AutoSize = true;
            this.uxUpdateTitleLabel.Location = new System.Drawing.Point(155, 49);
            this.uxUpdateTitleLabel.Name = "uxUpdateTitleLabel";
            this.uxUpdateTitleLabel.Size = new System.Drawing.Size(166, 13);
            this.uxUpdateTitleLabel.TabIndex = 11;
            this.uxUpdateTitleLabel.Text = "What is the name for this update?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1813, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenMenuButton,
            this.uxSaveAsMenuButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // uxOpenMenuButton
            // 
            this.uxOpenMenuButton.Name = "uxOpenMenuButton";
            this.uxOpenMenuButton.Size = new System.Drawing.Size(123, 22);
            this.uxOpenMenuButton.Text = "Open...";
            this.uxOpenMenuButton.Click += new System.EventHandler(this.UxOpenMenuButton_Click);
            // 
            // uxSaveAsMenuButton
            // 
            this.uxSaveAsMenuButton.Name = "uxSaveAsMenuButton";
            this.uxSaveAsMenuButton.Size = new System.Drawing.Size(123, 22);
            this.uxSaveAsMenuButton.Text = "Save As...";
            this.uxSaveAsMenuButton.Click += new System.EventHandler(this.UxSaveAsMenuButton_Click);
            // 
            // uxClearButton
            // 
            this.uxClearButton.Location = new System.Drawing.Point(862, 33);
            this.uxClearButton.Name = "uxClearButton";
            this.uxClearButton.Size = new System.Drawing.Size(446, 82);
            this.uxClearButton.TabIndex = 14;
            this.uxClearButton.Text = "Clear";
            this.uxClearButton.UseVisualStyleBackColor = true;
            this.uxClearButton.Click += new System.EventHandler(this.UxClearButton_Click);
            // 
            // Announcements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1813, 643);
            this.Controls.Add(this.uxClearButton);
            this.Controls.Add(this.uxUpdateTitleBox);
            this.Controls.Add(this.uxUpdateTitleLabel);
            this.Controls.Add(this.uxMySQLOutputBox);
            this.Controls.Add(this.uxMySQLOutputLabel);
            this.Controls.Add(this.uxConvert);
            this.Controls.Add(this.uxHTMLOutputBox);
            this.Controls.Add(this.uxDiscordOutputBox);
            this.Controls.Add(this.uxRawInputBox);
            this.Controls.Add(this.uxVersionBox);
            this.Controls.Add(this.uxHTMLOutputLabel);
            this.Controls.Add(this.uxDiscordOuputLabel);
            this.Controls.Add(this.uxRawInput);
            this.Controls.Add(this.uxVersionLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Announcements";
            this.Text = "Announcements";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxVersionLabel;
        private System.Windows.Forms.Label uxRawInput;
        private System.Windows.Forms.Label uxDiscordOuputLabel;
        private System.Windows.Forms.Label uxHTMLOutputLabel;
        private System.Windows.Forms.TextBox uxVersionBox;
        private System.Windows.Forms.TextBox uxRawInputBox;
        private System.Windows.Forms.TextBox uxDiscordOutputBox;
        private System.Windows.Forms.TextBox uxHTMLOutputBox;
        private System.Windows.Forms.Button uxConvert;
        private System.Windows.Forms.TextBox uxMySQLOutputBox;
        private System.Windows.Forms.Label uxMySQLOutputLabel;
        private System.Windows.Forms.TextBox uxUpdateTitleBox;
        private System.Windows.Forms.Label uxUpdateTitleLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxOpenMenuButton;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAsMenuButton;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveFileDialog;
        private System.Windows.Forms.Button uxClearButton;
    }
}

