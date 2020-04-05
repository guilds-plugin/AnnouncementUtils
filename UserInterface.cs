using System;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Announcements {
    public partial class Announcements : MetroForm {
        public Announcements() {
            InitializeComponent();
            // Set the project icon to the icon in the resources folder
            this.Icon = Properties.Resources.icon;
            
            bool discord = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("show_discord_output"));
            bool html = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("show_html_output"));
            bool mysql = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("show_mysql_output"));
            bool github = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("show_github_output"));

            this.uxDiscordOuputLabel.Visible = discord;
            this.uxDiscordCount.Visible = discord;
            this.uxDiscordOutputBox.Visible = discord;

            this.uxHTMLOutputBox.Visible = html;
            this.uxHTMLOutputLabel.Visible = html;

            this.uxMySQLOutputBox.Visible = mysql;
            this.uxMySQLOutputLabel.Visible = mysql;

            this.uxGitHubLabel.Visible = github;
            this.uxGitHubOutputBox.Visible = github;

        }

        /// <summary>
        /// Handles converting raw input text to multiple different output versions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxConvert_Click(object sender, EventArgs e) {
            string[] list = uxRawInputBox.Text.Split('\n');

            uxDiscordOutputBox.Clear();
            uxHTMLOutputBox.Clear();
            uxMySQLOutputBox.Clear();
            uxGitHubOutputBox.Clear();

            OutputMySQL(list);
            OutputDiscord(list);
            OutputHtml(list);
            MarkdownFormat(uxGitHubOutputBox, list);
        }

        /// <summary>
        /// Handles looping through the lines and generating the output
        /// </summary>
        /// <param name="list">The list of lines</param>
        /// <param name="box">The box to modify the output of</param>
        /// <param name="startText">The start text before headers</param>
        /// <param name="endText">The end text after headers</param>
        private void OutputMethod(string[] list, MetroTextBox box, string startText, string endText) {
            for (int i = 0; i < list.Length; i++) {
                string line = list[i];
                if (string.IsNullOrWhiteSpace(line)) {
                    Skip(box);
                }
                else {
                    if (IsHeader(line)) {
                        box.AppendText(startText + line + endText);
                        Skip(box);
                    }
                    else {
                        box.AppendText("- " + line);
                        Skip(box);
                    }
                }
            }
        }

        /// <summary>
        /// Handles opening a file into the announcements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxOpenMenuButton_Click(object sender, EventArgs e) {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK) {
                ClearAll();
                try {
                    string fn = @uxOpenFileDialog.FileName;
                    string contents = File.ReadAllText(fn);
                    string[] split = contents.Split('~');
                    uxVersionBox.Text = split[0];
                    uxUpdateTitleBox.Text = split[1];
                    uxRawInputBox.Text = split[2];
                }
                catch (Exception ex) {
                    sendError(ex);
                }
            }
        }

        /// <summary>
        /// Handles saving announcements to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxSaveAsMenuButton_Click(object sender, EventArgs e) {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    string fn = uxSaveFileDialog.FileName;
                    string contents = uxVersionBox.Text + "~" + uxUpdateTitleBox.Text + "~" + uxRawInputBox.Text;
                    File.WriteAllText(fn, contents);
                }
                catch (Exception ex) {
                    sendError(ex);
                }
            }
        }

        /// <summary>
        /// Show a textbox to user containing error
        /// </summary>
        /// <param name="ex">The error that the user got</param>
        private void sendError(Exception ex) {
            MessageBox.Show("The following error occurred:" + ex.ToString());
        }

        /// <summary>
        /// Clears all current text in the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxClearButton_Click(object sender, EventArgs e) {
            ClearAll();
        }

        /// <summary>
        /// Checks if a line is a header or not for outputs
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private bool IsHeader(string line) {
            return line.Contains("Features") || line.Contains("Bug Fixes") || line.Contains("Changes") || line.Contains("Note") || line.Contains("Known Issues");
        }

        /// <summary>
        /// Easy method to skip lines
        /// </summary>
        /// <param name="box"></param>
        private void Skip(MetroTextBox box) {
            box.AppendText(Environment.NewLine);
        }

        /// <summary>
        /// Clear all text boxes
        /// </summary>
        private void ClearAll() {
            uxVersionBox.Clear();
            uxUpdateTitleBox.Clear();
            uxRawInputBox.Clear();
            uxDiscordOutputBox.Clear();
            uxMySQLOutputBox.Clear();
            uxHTMLOutputBox.Clear();
            uxGitHubOutputBox.Clear();
        }

        /// <summary>
        /// Handles markdown format for Discord & GitHub format
        /// </summary>
        /// <param name="box">The box that is being outputted</param>
        /// <param name="list">Contents of the changelog</param>
        private void MarkdownFormat(MetroTextBox box, string[] list) {
            box.AppendText("**UPDATE**");
            Skip(box);
            Skip(box);
            box.AppendText(uxUpdateTitleBox.Text);
            Skip(box);
            Skip(box);
            OutputMethod(list, box, "**", "**");
            Skip(box);
        }

        /// <summary>
        /// Easy handling of creating the output for the mysql text box
        /// </summary>
        /// <param name="list">List of data</param>
        private void OutputMySQL(string[] list) {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Length; i++) {
                string line = list[i];
                if (string.IsNullOrWhiteSpace(line)) {
                    sb.Append("\\n");
                }
                else {
                    if (IsHeader(line)) {
                        sb.Append("&6&l" + line + "\\n");
                    }
                    else {
                        sb.Append("&a- " + line + "\\n");
                    }
                }
            }
            uxMySQLOutputBox.Text = sb.ToString();
        }

        /// <summary>
        /// Easy handling of creating the output for the discord text box
        /// </summary>T
        /// <param name="list">List of data</param>
        private void OutputDiscord(string[] list) {
            MarkdownFormat(uxDiscordOutputBox, list);
            uxDiscordOutputBox.AppendText("**" + ConfigurationManager.AppSettings.Get("project_name") + " v" + uxVersionBox.Text + " is now live!**");
            Skip(uxDiscordOutputBox);
            uxDiscordOutputBox.AppendText("Plugin Page: " + ConfigurationManager.AppSettings.Get("project_page"));

            uxDiscordCount.Text = "Character Count: " + Convert.ToString(uxDiscordOutputBox.Text.Length) + "/2000";
        }

        /// <summary>
        /// Easy handling of creating the output for the html text box
        /// </summary>
        /// <param name="list">List of data</param>
        private void OutputHtml(string[] list) {
            OutputMethod(list, uxHTMLOutputBox, "[B]", "[/B]");
            Skip(uxHTMLOutputBox);
        }
    }
}
