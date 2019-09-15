using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Announcements {
    public partial class Announcements : Form {
        public Announcements() {
            InitializeComponent();
            this.Icon = Properties.Resources.icon;
        }

        private void UxConvert_Click(object sender, EventArgs e) {
            // Set the current text in the input box to a variable
            string originalText = uxRawInputBox.Text;

            // Split the current text by new lines.
            string[] list = originalText.Split('\n');

            // MYSQL OUTPUT BOX START

            // Create variable for MySQL output
            string mysqlOutput = "";
            for (int i = 0; i < list.Length; i++) {
                string line = list[i];
                if (string.IsNullOrWhiteSpace(line)) {
                    mysqlOutput += "\\n";
                }
                else {
                    if (line.Contains("Features") || line.Contains("Bug Fixes") || line.Contains("Changes")) {
                        mysqlOutput += "&6&l" + line + "\\n";
                    }
                    else {
                        mysqlOutput += "&a- " + line + "\\n";
                    }
                }
            }
            uxMySQLOutputBox.Text = mysqlOutput;
            // MYSQL OUTPUT BOX STOP

            // DISCORD OUTPUT BOX START
            uxDiscordOutputBox.AppendText("**UPDATE**");
            uxDiscordOutputBox.AppendText(Environment.NewLine);
            uxDiscordOutputBox.AppendText(Environment.NewLine);
            uxDiscordOutputBox.AppendText(uxUpdateTitleBox.Text);
            uxDiscordOutputBox.AppendText(Environment.NewLine);
            uxDiscordOutputBox.AppendText(Environment.NewLine);
            for (int i = 0; i < list.Length; i++) {
                string line = list[i];
                if (string.IsNullOrWhiteSpace(line)) {
                    uxDiscordOutputBox.AppendText(Environment.NewLine);
                }
                else {
                    if (line.Contains("Features") || line.Contains("Bug Fixes") || line.Contains("Changes")) {
                        uxDiscordOutputBox.AppendText("**" + line + "**");
                        uxDiscordOutputBox.AppendText(Environment.NewLine);
                    } else {
                        uxDiscordOutputBox.AppendText("- " + line);
                        uxDiscordOutputBox.AppendText(Environment.NewLine);
                    }
                }
            }
            uxDiscordOutputBox.AppendText(Environment.NewLine);
            uxDiscordOutputBox.AppendText("**Guilds v" + uxVersionBox.Text + " is now live!**");
            uxDiscordOutputBox.AppendText(Environment.NewLine);
            uxDiscordOutputBox.AppendText("Plugin Page: https://www.spigotmc.org/resources/guilds.66176/");
            // DISCORD OUTPUT BOX END

            // HTML OUTPUT BOX START
            for (int i = 0; i < list.Length; i++) {
                string line = list[i];
                if (string.IsNullOrWhiteSpace(line)) {
                    uxHTMLOutputBox.AppendText(Environment.NewLine);
                }
                else {
                    if (line.Contains("Features") || line.Contains("Bug Fixes") || line.Contains("Changes")) {
                        uxHTMLOutputBox.AppendText("[B]" + line + "[/B]");
                        uxHTMLOutputBox.AppendText(Environment.NewLine);
                    }
                    else {
                        uxHTMLOutputBox.AppendText("- " + line);
                        uxHTMLOutputBox.AppendText(Environment.NewLine);
                    }
                }
            }
            // HTML OUTPUT BOX END
        }

        private void UxOpenMenuButton_Click(object sender, EventArgs e) {
            if (uxOpenFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    string fn = @uxOpenFileDialog.FileName;
                    string contents = File.ReadAllText(fn);
                    string[] split = contents.Split(',');
                    uxVersionBox.Text = split[0];
                    uxUpdateTitleBox.Text = split[1];
                    uxRawInputBox.Text = split[2];
          
                }
                catch (Exception ex) {
                    sendError(ex);
                }
            }
        }

        private void UxSaveAsMenuButton_Click(object sender, EventArgs e) {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    string fn = uxSaveFileDialog.FileName;
                    string contents = uxVersionBox.Text + "," + uxUpdateTitleBox.Text + "," + uxRawInputBox.Text;
                    File.WriteAllText(fn, contents);
                } catch(Exception ex) {
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

        private void UxClearButton_Click(object sender, EventArgs e) {
            uxVersionBox.Clear();
            uxUpdateTitleBox.Clear();
            uxRawInputBox.Clear();
            uxDiscordOutputBox.Clear();
            uxMySQLOutputBox.Clear();
            uxHTMLOutputBox.Clear();
        }
    }
}
