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
using System.Reflection;

// TODO C# documentation comments (XML) for sWall Activity Manager
// TODO Add info about each field to the help tab (or somewhere)
// TODO Progess bar for additional game files?
// TODO Formet everything nicely

namespace sWall_Activity_Manager
{
    public partial class SWallForm : Form
    {
        string activitySetFilePath;
        string activitiesDirectoryPath;

        public SWallForm()
        {
            InitializeComponent();
            
            gameRadioButton.Checked = true;

            mediaGroupBox.Enabled = false;
            browserGroupBox.Enabled = false;

            activitySetFilePathTextBox.Text = Properties.Settings.Default.activitySetFilePath;
            activitiesDirectoryPathTextBox.Text = Properties.Settings.Default.activitiesDirectoryPath;


            // TODO Replace with application settings variables
            activitySetFilePath = Properties.Settings.Default.activitySetFilePath;
            activitiesDirectoryPath = Properties.Settings.Default.activitiesDirectoryPath;

            // Check if the activity set path is correct
            // TODO Add option to generate new activity set and/or browse for new path
            // TODO Move this into addActivityButton_Clicked?
            if (!File.Exists(activitySetFilePath))
            {
                MessageBox.Show($"The activity set file was expected to be at\n{activitySetFilePath}\nbut was not found.\n\nCheck that this is the correct path or if the file was deleted.",
                    "sWall Activity Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // TODO Find somewhere in the form to display this
            // Build version
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
            string displayableVersion = $"{buildDate}";
            //aboutTextBox.AppendText($"Last built on:\t{buildDate}{Environment.NewLine}For assistance contact robbiegraham@cmail.carleton.ca");
        }

        private void gameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameGroupBox.Enabled = true;
            mediaGroupBox.Enabled = false;
            browserGroupBox.Enabled = false;
        }

        private void mediaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameGroupBox.Enabled = false;
            mediaGroupBox.Enabled = true;
            browserGroupBox.Enabled = false;
        }

        private void browserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameGroupBox.Enabled = false;
            mediaGroupBox.Enabled = false;
            browserGroupBox.Enabled = true;
        }


        // TODO Remove
        private void aboutButton_Click(object sender, EventArgs e)
        {
            Form aboutForm = new Form();
            aboutForm.ShowDialog();
        }

        private void browseThumbnailButton_Click(object sender, EventArgs e)
        {
            if (openThumbnailFileDialog.ShowDialog() == DialogResult.OK)
            {
                thumbnailTextBox.Text = openThumbnailFileDialog.FileName;
            }
        }

        private void browseAdditionalGameFilesFolderButton_Click(object sender, EventArgs e)
        {
            if (additionalGameFilesFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.additionalGameFilesFolderTextBox.Text = additionalGameFilesFolderBrowserDialog.SelectedPath;
            }
        }

        // TODO Remove
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // TODO Finish
        private void gameFolderTextBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        /// <summary>
        /// Creates an activity entry in the activity set markup file and transfers files to the sWall machine.
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            // Ensure all textbox fields required to add an activity are filled
            // TODO Ensure resolution is valid
            // TODO Ensure file paths exist for video, game exe, etc.
            if (String.IsNullOrWhiteSpace(titleTextBox.Text) || String.IsNullOrWhiteSpace(descriptionTextBox.Text)  || String.IsNullOrWhiteSpace(tagsTextBox.Text) || String.IsNullOrWhiteSpace(thumbnailTextBox.Text)
                || (gameRadioButton.Checked && (String.IsNullOrWhiteSpace(gameExecutableTextBox.Text) || (additionalGameFilesCheckBox.Checked && String.IsNullOrWhiteSpace(additionalGameFilesFolderTextBox.Text))))
                || (mediaRadioButton.Checked && (String.IsNullOrWhiteSpace(videoTextBox.Text) || String.IsNullOrWhiteSpace(videoWidthTextBox.Text) || String.IsNullOrWhiteSpace(videoHeightTextBox.Text)))
                || (browserRadioButton.Checked && String.IsNullOrWhiteSpace(urlTextBox.Text)))
            {
                MessageBox.Show("Empty field(s)",
                    "sWall Activity Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            else
            { 
                // Create a temporary file to add the new activity at the top of the list of activities
                string tempFilePath = String.Empty;
                try
                {
                    tempFilePath = Path.GetTempFileName();
                    FileInfo fileInfo = new FileInfo(tempFilePath)
                    {
                        Attributes = FileAttributes.Temporary
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unable to create temporary file or set attributes while updating activity set\n{ex.Message}",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }




                // Trim whitespace and replace with underscores
                string activityName = System.Text.RegularExpressions.Regex.Replace(titleTextBox.Text.Trim(), @"\s+", "_");
                




                // Move around files




                // Path of the directory where the new activity will be located
                string activityDirectory = $@"{activitiesDirectoryPath}{activityName}\";

                // Check to see if an activity wit the same name already exists
                if (Directory.Exists(activityDirectory))
                {
                    // Let the user know and don't add the activity
                    MessageBox.Show("An activity with that name already exists. Please choose another title.",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    // Create a new activity directory
                    Directory.CreateDirectory(activityDirectory);

                    // Copy all necessecary files

                    // Game
                    if (gameRadioButton.Checked)
                    {
                        if (additionalGameFilesCheckBox.Checked)
                        {
                            // Copy all additional game files
                            foreach (string file in Directory.GetFiles(additionalGameFilesFolderTextBox.Text))
                            {
                                File.Copy(file, $"{activityDirectory}{Path.GetFileName(file)}");
                            }
                        }
                        // Copy the game executable. Overwrite if it already exists because the original executable file is likeyly to be stored in the additional files directory.
                        File.Copy(gameExecutableTextBox.Text, $"{activityDirectory}{Path.GetFileName(gameExecutableTextBox.Text)}", true);
                    }

                    // Media
                    if (mediaRadioButton.Checked)
                    {
                        File.Copy(videoTextBox.Text, $"{activityDirectory}{Path.GetFileName(videoTextBox.Text)}");
                    }

                    // Thumbnail. Overwrite if it already exists because the original thumbnail file is likeyly to be stored in the additional files directory.
                    File.Copy(thumbnailTextBox.Text, $"{activityDirectory}{Path.GetFileName(thumbnailTextBox.Text)}", true);
                }





                // HACK Put this string creation in a method?

                // Entry to the activity set for the new activity
                string newActivityString;

                newActivityString = "  <Activity>\r\n";

                // Name
                newActivityString += $"    <Name>{activityName}</Name>\r\n";

                // Image location (thumbnail)
                newActivityString += $"    <ImageLocation>{Path.GetFileName(thumbnailTextBox.Text)}</ImageLocation>\r\n";

                // Type
                newActivityString += "    <Type>";
                if (gameRadioButton.Checked) newActivityString += "Game";
                else if (browserRadioButton.Checked) newActivityString += "Browser";
                else newActivityString += "Media";
                newActivityString += "</Type>\r\n";

                // Tags
                newActivityString += "    <Tags>\r\n";
                // Separate tag string into individual strings and remove whitespace
                foreach (string t in tagsTextBox.Text.Split(',').Select(sValue => sValue.Trim()).Where(sValues => !String.IsNullOrWhiteSpace(sValues)).ToArray())
                {
                    newActivityString += $"      <Tag>{t}</Tag>\r\n";
                }
                newActivityString += "    </Tags>\r\n";

                // Descpription
                newActivityString += $"    <Description>{titleTextBox.Text.ToUpper()} - {descriptionTextBox.Text}</Description>\r\n";

                // Game
                if (gameRadioButton.Checked)
                {
                    // Game executable
                    newActivityString += $"    <Files>\r\n      <File>{Path.GetFileName(gameExecutableTextBox.Text)}</File>\r\n";

                    // Additional files
                    if (additionalGameFilesCheckBox.Checked)
                    {
                        foreach (string file in Directory.GetFiles(additionalGameFilesFolderTextBox.Text))
                        {
                            newActivityString += $"      <File>{Path.GetFileName(file)}</File>\r\n";
                        }
                    }
                    newActivityString += "    </Files>\r\n";
                }
                // Media
                if (mediaRadioButton.Checked)
                {
                    newActivityString += $"    <Files>\r\n      <File>{Path.GetFileName(videoTextBox.Text)}</File>\r\n    </Files>\r\n";
                    newActivityString += $"    <Resolution>\r\n      <Width>{videoWidthTextBox.Text}</Width>\r\n      <Height>{videoHeightTextBox.Text}</Height>\r\n    </Resolution>\r\n";
                }

                // Browser
                if (browserRadioButton.Checked)
                {
                    newActivityString += $"    <Files>\r\n      <File>Browser.exe</File>\r\n    </Files>\r\n    <Url>{urlTextBox.Text}</Url>\r\n";
                }

                newActivityString += "  </Activity>";





                // Add the new activity to the top of the activity list
                using (StreamWriter streamWriter = new StreamWriter(tempFilePath))
                {
                    foreach (string line in File.ReadLines(activitySetFilePath))
                    {
                        // To add the new activity to the top, must copy to a temporary file first
                        try
                        {
                            // Copy the current line to the temporary file
                            streamWriter.WriteLine(line);
                            // Put the new activity immediately after the XML setup
                            if (line.Contains(@"<Activities xmlns="""">"))
                            {
                                // Write the new activity and comment to the temporary file
                                streamWriter.WriteLine($"\r\n  <!-- Added by sWall Activity Manager on { DateTime.Now.ToString()} -->");
                                streamWriter.WriteLine(newActivityString);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error writing to temporary file while updating activity set\n{ex.Message}",
                                "sWall Activity Manager",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }

                // Copy from temporary file to activity set
                File.Copy(tempFilePath, activitySetFilePath, true);

                // Delete temporary file
                // NOTE May be a dangerous way to proceed e.g. if the pogram stops before this code is reached. Look into other methods...
                try
                {
                    if (File.Exists(tempFilePath))
                    {
                        File.Delete(tempFilePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleteing temporary file while updating activity set:\n{ex.Message}",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                MessageBox.Show("Activity added",
                                "sWall Activity Manager",
                                MessageBoxButtons.OK);

                // Clear all fields
                titleTextBox.Text = String.Empty;
                descriptionTextBox.Text = String.Empty;
                tagsTextBox.Text = String.Empty;
                thumbnailTextBox.Text = String.Empty;

                gameExecutableTextBox.Text = String.Empty;
                additionalGameFilesFolderTextBox.Text = String.Empty;

                videoTextBox.Text = String.Empty;
                videoHeightTextBox.Text = String.Empty;
                videoWidthTextBox.Text = String.Empty;

                urlTextBox.Text = String.Empty;
            }
        }

        // TODO Remove
        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void additionalGameFilescheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (additionalGameFilesCheckBox.Checked)
            {
                additionalGameFilesFolderTextBox.Enabled = true;
                browseAdditionalGameFilesFolderButton.Enabled = true;
            }
            else
            {
                additionalGameFilesFolderTextBox.Enabled = false;
                browseAdditionalGameFilesFolderButton.Enabled = false;
            }
        }

        private void browseGameExecutableButton_Click(object sender, EventArgs e)
        {
            if (openGameExecutableFileDialog.ShowDialog() == DialogResult.OK)
            {
                gameExecutableTextBox.Text = openGameExecutableFileDialog.FileName;
            }
        }

        private void browseVideoButton_Click(object sender, EventArgs e)
        {
            if (openVideoFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoTextBox.Text = openVideoFileDialog.FileName;
            }
        }

        // TODO Remove
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // TODO Remove
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sWallForm_Load(object sender, EventArgs e)
        {

        }
        
        // TODO Add a file broswer dialog
        private void activitySetFilePathTextBox_TextChanged(object sender, EventArgs e)
        {

            Properties.Settings.Default.activitySetFilePath = activitySetFilePathTextBox.Text;
            Properties.Settings.Default.Save();
        }

        // TODO Remove
        private void displayActivitySetFilePathButton_Click(object sender, EventArgs e)
        {

        }

        // TODO Add a folder broswer dialog
        private void activitiesDirectoryPathTextBox_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.activitiesDirectoryPath = activitiesDirectoryPathTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
