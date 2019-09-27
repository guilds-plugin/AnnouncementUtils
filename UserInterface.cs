using System;
using System.IO;
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
        }

        /// <summary>
        /// Handles converting raw input text to multiple different output versions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    if (IsHeader(line)) {
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
            Skip(uxDiscordOutputBox);
            Skip(uxDiscordOutputBox);
            uxDiscordOutputBox.AppendText(uxUpdateTitleBox.Text);
            Skip(uxDiscordOutputBox);
            Skip(uxDiscordOutputBox);
            OutputMethod(list, uxDiscordOutputBox, "**", "**");
            Skip(uxDiscordOutputBox);
            if (LangUpdate()) {
                ImplementLanguageMessage(uxDiscordOutputBox, "```", "```");
            }
            uxDiscordOutputBox.AppendText("**Guilds v" + uxVersionBox.Text + " is now live!**");
            Skip(uxDiscordOutputBox);
            uxDiscordOutputBox.AppendText("Plugin Page: https://www.spigotmc.org/resources/guilds.66176/");
            // DISCORD OUTPUT BOX END

            // HTML OUTPUT BOX START
            OutputMethod(list, uxHTMLOutputBox, "[B]", "[/B]");
            Skip(uxHTMLOutputBox);
            if (LangUpdate()) {
                ImplementLanguageMessage(uxHTMLOutputBox, "[CODE]", "[/CODE]");
            }
            // HTML OUTPUT BOX END


            // Set suggested file name for saving & default ext
            uxSaveFileDialog.DefaultExt = "txt";
            uxSaveFileDialog.FileName = uxVersionBox.Text;
        }

        /// <summary>
        /// Easy way to check if language update or not
        /// </summary>
        /// <returns>Update contains language update or not</returns>
        private bool LangUpdate() {
            return uxRequiresLanguageUpdate.Checked;
        }

        /// <summary>
        /// Handles generating the output text for letting users know about language updates
        /// </summary>
        /// <param name="box">The box to modify</param>
        /// <param name="startText">The start text for the code</param>
        /// <param name="endText">The end text for the code</param>
        private void ImplementLanguageMessage(MetroTextBox box, string startText, string endText) {
            box.AppendText("Note: This update requires langauge updates");
            Skip(box);
            box.AppendText(startText);
            Skip(box);
            box.AppendText("1) guild console update-languages");
            Skip(box);
            box.AppendText("2) guild confirm");
            Skip(box);
            box.AppendText(endText);
            Skip(box);
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

        /// <summary>
        /// Handles saving announcements to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UxSaveAsMenuButton_Click(object sender, EventArgs e) {
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    string fn = uxSaveFileDialog.FileName;
                    string contents = uxVersionBox.Text + "," + uxUpdateTitleBox.Text + "," + uxRawInputBox.Text;
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
            return line.Contains("Features") || line.Contains("Bug Fixes") || line.Contains("Changes");
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
        }

        private void uxRequiresLanguageUpdate_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
