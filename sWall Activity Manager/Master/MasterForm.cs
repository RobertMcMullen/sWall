using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net.Sockets;

namespace sWallActivityManager
{
    public partial class MasterForm : Form
    {
        private UdpClient client;
        private XmlDocument activitySet;

        private string activitySetFilePath;
        private string activitiesDirectoryPath;

        // HACK Confirm actual IPs and ports
        private string[] slaveIPs = new string[] { "127.0.0.1", "126.0.0.1", "126.0.0.1", "126.0.0.1" };
        // HACK Confirm free ports
        private int[] slavePorts = new int[] { 69, 69, 69, 69 };
        private int sourcePort = 4001;

        public MasterForm()
        {
            InitializeComponent();

            this.Size = new Size(700, 550);

            // HACK Confirm actual paths
            // Paths
            activitySetFilePath = @"C:\Users\rober\OneDrive\Documents\Skool\SYSC 4907\Shared Drive\activitySet.xml";
            activitiesDirectoryPath = @"C:\Users\rober\OneDrive\Documents\Skool\SYSC 4907\Shared Drive\Activities";

            // Activity set xml
            activitySet = new XmlDocument();
            activitySet.Load(activitySetFilePath);

            // UDP Communication
            client = new UdpClient(sourcePort);

            // Display all activity names in list box
            XmlNodeList elemList = activitySet.GetElementsByTagName("Name");
            for (int i = 0; i < elemList.Count; i++)
            {
                activitiesListBox.Items.Add(elemList[i].InnerXml);
            }
        }

        // Radio buttons

        private void EditRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            editActivitiesGroupBox.Enabled = true;
        }

        private void AddRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ClearFields();
            editActivitiesGroupBox.Enabled = false;
        }

        private void GameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameGroupBox.Enabled = true;
            mediaGroupBox.Enabled = false;
            browserGroupBox.Enabled = false;
        }

        private void MediaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameGroupBox.Enabled = false;
            mediaGroupBox.Enabled = true;
            browserGroupBox.Enabled = false;
        }

        private void BrowserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gameGroupBox.Enabled = false;
            mediaGroupBox.Enabled = false;
            browserGroupBox.Enabled = true;
        }

        private void AdditionalGameFilescheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (additionalGameFilesCheckBox.Checked)
            {
                additionalGameFilesTextBox.Enabled = true;
                browseAdditionalGameFilesButton.Enabled = true;
            }
            else
            {
                additionalGameFilesTextBox.Enabled = false;
                browseAdditionalGameFilesButton.Enabled = false;
            }
        }

        // Browse files buttons

        private void BrowseThumbnailButton_Click(object sender, EventArgs e)
        {
            if (openThumbnailFileDialog.ShowDialog() == DialogResult.OK)
            {
                thumbnailTextBox.Text = openThumbnailFileDialog.FileName;
            }
        }

        private void BrowseGameExecutableButton_Click(object sender, EventArgs e)
        {
            if (openGameExecutableFileDialog.ShowDialog() == DialogResult.OK)
            {
                gameExecutableTextBox.Text = openGameExecutableFileDialog.FileName;
            }
        }

        private void BrowseAdditionalGameFilesButton_Click(object sender, EventArgs e)
        {
            if (openAdditionalGameFilesDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> additionalGameFilesList = new List<string>();
                foreach (String additionalfile in openAdditionalGameFilesDialog.FileNames)
                {
                    additionalGameFilesList.Add(additionalfile);
                }
                additionalGameFilesTextBox.Lines = additionalGameFilesList.ToArray();
            }
        }

        private void BrowseVideoButton_Click(object sender, EventArgs e)
        {
            if (openVideoFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoTextBox.Text = openVideoFileDialog.FileName;
            }
        }

        /// <summary>
        /// Updates the field of the form with the information of the selected activity from the activity set.
        /// </summary>
        private void ActivitiesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If no activity is selected, don't do anything
            if (activitiesListBox.SelectedIndex == -1) return;

            // Clear the form
            ClearFields();

            // Display activity entry in form
            XmlNodeList xnList = activitySet.SelectNodes("/Activities/Activity");
            foreach (XmlNode node in xnList)
            {
                if (node["Name"].InnerText.Equals(activitiesListBox.SelectedItem.ToString()))
                {
                    // Directory of the target activity
                    string activityDirectory = Path.Combine(activitiesDirectoryPath, activitiesListBox.SelectedItem.ToString());

                    XmlNodeList tagsNodeList = node.SelectSingleNode("Tags").SelectNodes("Tag");
                    XmlNodeList filesNodeList = node.SelectSingleNode("Files").SelectNodes("File");

                    // Reset radio buttons
                    gameRadioButton.Checked = false;
                    mediaRadioButton.Checked = false;
                    browserRadioButton.Checked = false;

                    switch (node.SelectSingleNode("Type").InnerText)
                    {
                        case "Game":
                            gameRadioButton.Checked = true;
                            gameExecutableTextBox.Text = Path.Combine(activityDirectory, node.SelectSingleNode("Files").SelectSingleNode("File").InnerText);

                            // All files in the activity directory
                            List<string> additionalGameFilesList = new List<string>(Directory.GetFiles(activityDirectory));
                            Console.WriteLine(additionalGameFilesList.ToString());
                            // Remove game executable
                            additionalGameFilesList.Remove(Path.Combine(activityDirectory, node.SelectSingleNode("Files").SelectSingleNode("File").InnerText));
                            // Remove game executable
                            additionalGameFilesList.Remove(Path.Combine(activityDirectory, node.SelectSingleNode("ImageLocation").InnerText));
                            // Only additional files will remain
                            additionalGameFilesTextBox.Lines = additionalGameFilesList.ToArray();

                            // Check the box if there are additional files
                            additionalGameFilesCheckBox.Checked = additionalGameFilesList.Any() ? true : false;
                            break;

                        case "Media":
                            mediaRadioButton.Checked = true;
                            videoTextBox.Text = Path.Combine(activityDirectory, node.SelectSingleNode("Files").SelectSingleNode("File").InnerText);
                            videoHeightTextBox.Text = node.SelectSingleNode("Resolution").SelectSingleNode("Height").InnerText;
                            videoWidthTextBox.Text = node.SelectSingleNode("Resolution").SelectSingleNode("Width").InnerText;
                            break;

                        case "Browser":
                            browserRadioButton.Checked = true;
                            urlTextBox.Text = node.SelectSingleNode("Url").InnerText;
                            break;
                    }

                    nameTextBox.Text = node.SelectSingleNode("Name").InnerText;
                    thumbnailTextBox.Text = Path.Combine(activityDirectory, node.SelectSingleNode("ImageLocation").InnerText);

                    List<string> tagsList = new List<string>();
                    foreach (XmlNode tagNode in tagsNodeList)
                    {
                        tagsList.Add(tagNode.InnerText);
                    }
                    tagsTextBox.Lines = tagsList.ToArray();


                    descriptionTextBox.Text = node.SelectSingleNode("Description").InnerText;

                }
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Ensure all textbox fields required to add an activity are filled. Don't check for validity, just make sure they aren't empty
            if (String.IsNullOrWhiteSpace(nameTextBox.Text) || String.IsNullOrWhiteSpace(descriptionTextBox.Text) || String.IsNullOrWhiteSpace(tagsTextBox.Text) || String.IsNullOrWhiteSpace(thumbnailTextBox.Text)
                || (gameRadioButton.Checked && (String.IsNullOrWhiteSpace(gameExecutableTextBox.Text) || (additionalGameFilesCheckBox.Checked && String.IsNullOrWhiteSpace(additionalGameFilesTextBox.Text))))
                || (mediaRadioButton.Checked && (String.IsNullOrWhiteSpace(videoTextBox.Text) || String.IsNullOrWhiteSpace(videoWidthTextBox.Text) || String.IsNullOrWhiteSpace(videoHeightTextBox.Text)))
                || (browserRadioButton.Checked && String.IsNullOrWhiteSpace(urlTextBox.Text)))
            {
                MessageBox.Show("Empty field(s)",
                    "sWall Activity Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            // Add a new activity
            if (addRadioButton.Checked)
            {
                AddActivity();
                
                // Add activity to the top of the list box
                activitiesListBox.Items.Insert(0, nameTextBox.Text);

                // Send updated file name via UDP messages to each slave
                for (int slave = 0; slave < 4; slave++)
                {
                    client.Send(Encoding.ASCII.GetBytes(nameTextBox.Text), Encoding.ASCII.GetBytes(nameTextBox.Text).Length, slaveIPs[slave], slavePorts[slave]);
                }

                MessageBox.Show("Activity added",
                                "sWall Activity Manager",
                                MessageBoxButtons.OK);
                ClearFields();
            }

            // Edit the selected activity
            else
            {
                // If no activity is selected, don't do anything
                if (activitiesListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("No activity selected",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;

                }

                // Create a temporary directory with a random filename to store all files
                string tempDirectory = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                Directory.CreateDirectory(tempDirectory);

                // Save the files currently in the form in this directory
                // We don't know which ones have been changed by the user and which are still on the shared drive (and thus will be deleted)
                // So just save all of them

                // Thumbnail
                string tempThumbnailPath = Path.Combine(tempDirectory, Path.GetFileName(thumbnailTextBox.Text));
                File.Copy(thumbnailTextBox.Text, tempThumbnailPath);
                thumbnailTextBox.Text = tempThumbnailPath;

                // Game
                if (gameRadioButton.Checked)
                {
                    // Game executable
                    string tempGameExecutable = Path.Combine(tempDirectory, Path.GetFileName(gameExecutableTextBox.Text));
                    File.Copy(gameExecutableTextBox.Text, tempGameExecutable);
                    gameExecutableTextBox.Text = tempGameExecutable;
                    // Additional files
                    if (additionalGameFilesCheckBox.Checked)
                    {
                        List<string> tempAdditionalGameFiles = new List<string>();
                        foreach (string file in additionalGameFilesTextBox.Lines)
                        {
                            File.Copy(file, Path.Combine(tempDirectory, Path.GetFileName(file)));
                            tempAdditionalGameFiles.Add(Path.GetFileName(file));
                        }
                        additionalGameFilesTextBox.Lines = tempAdditionalGameFiles.ToArray();
                    }
                }
                // Media
                if (mediaRadioButton.Checked)
                {
                    // Video
                    string tempVideoPath = Path.Combine(tempDirectory, Path.GetFileName(videoTextBox.Text));
                    File.Copy(videoTextBox.Text, tempVideoPath);
                    videoTextBox.Text = tempVideoPath;
                }

                // Delete the activity
                DeleteActivity();

                // Add the activity
                AddActivity();

                // Delete the temporary directory along with all the files within it
                Directory.Delete(tempDirectory, true);

                // Send message for old activity name if name has changed
                string oldActivityName = activitiesListBox.GetItemText(activitiesListBox.SelectedItem);
                if (!oldActivityName.Equals(nameTextBox.Text))
                {
                    for (int slave = 0; slave < 4; slave++)
                    {
                        client.Send(Encoding.ASCII.GetBytes(oldActivityName), Encoding.ASCII.GetBytes(oldActivityName).Length, slaveIPs[slave], slavePorts[slave]);
                    }
                }

                // Replace activity name in list box
                activitiesListBox.Items.Remove(activitiesListBox.SelectedItem);
                activitiesListBox.Items.Insert(0, nameTextBox.Text);

                // Send message for new activity name
                for (int slave = 0; slave < 4; slave++)
                {
                    client.Send(Encoding.ASCII.GetBytes(nameTextBox.Text), Encoding.ASCII.GetBytes(nameTextBox.Text).Length, slaveIPs[slave], slavePorts[slave]);
                }

                ClearFields();

                MessageBox.Show("Activity editted",
                            "sWall Activity Manager",
                            MessageBoxButtons.OK);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteActivity();

            activitiesListBox.Items.Remove(activitiesListBox.SelectedItem);
            
            for (int slave = 0; slave < 4; slave++)
            {
                client.Send(Encoding.ASCII.GetBytes(nameTextBox.Text), Encoding.ASCII.GetBytes(nameTextBox.Text).Length, slaveIPs[slave], slavePorts[slave]);
            }

            MessageBox.Show("Activity deleted",
                            "sWall Activity Manager",
                            MessageBoxButtons.OK);
        }

        /// <summary>
        /// Creates an activity entry in the activity set file and transfers files to the shared drive.
        /// </summary>
        private void AddActivity()
        {
            // Ensure that an activity with that name does not already exist in the xml
            foreach (XmlNode node in activitySet.SelectNodes("/Activities/Activity"))
            {
                if (node["Name"].InnerText.Equals(nameTextBox.Text))
                {
                    MessageBox.Show("An activity with that name already exists",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return;
                }
            }

            // Ensure that file paths are valid

            // Thumbnail
            if (!File.Exists(thumbnailTextBox.Text))
            {
                MessageBox.Show($"Thumbnail image does not exist.\n{thumbnailTextBox.Text}",
                    "sWall Activity Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Game
            if (gameRadioButton.Checked)
            {
                if (!File.Exists(gameExecutableTextBox.Text))
                {
                    MessageBox.Show($"Game executable does not exist.\n{gameExecutableTextBox.Text}",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (additionalGameFilesCheckBox.Checked)
                {
                    // Check each addtional file
                    foreach (string additionalFile in additionalGameFilesTextBox.Lines)
                    {
                        if (!File.Exists(additionalFile))
                        {
                            MessageBox.Show($"Additional file(s) does not exist.\n{additionalFile}",
                                "sWall Activity Manager",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            // Media
            if (mediaRadioButton.Checked && !File.Exists(videoTextBox.Text))
            {
                MessageBox.Show($"Video file does not exist.\n{videoTextBox.Text}",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
            
            // Create a directory for the new activity
            string activityDirectory = Path.Combine(activitiesDirectoryPath, nameTextBox.Text);
            try
            {
                Directory.CreateDirectory(activityDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating new activity directory.\n{ex.Message}",
                    "sWall Activity Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Copy all necessesary files
            
            // Thumbnail
            try
            {
                File.Copy(thumbnailTextBox.Text, Path.Combine(activityDirectory, Path.GetFileName(thumbnailTextBox.Text)), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error copying thumbnail.\n{ex.Message}",
                    "sWall Activity Manager",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Game
            if (gameRadioButton.Checked)
            {
                // Copy the game executable
                try
                {
                    File.Copy(gameExecutableTextBox.Text, Path.Combine(activityDirectory, Path.GetFileName(gameExecutableTextBox.Text)), true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error copying game file.\n{ex.Message}",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                if (additionalGameFilesCheckBox.Checked)
                {
                    // Copy all additional game files
                    foreach (string additionalFile in additionalGameFilesTextBox.Lines)
                    {
                        try
                        {
                            File.Copy(additionalFile, Path.Combine(activityDirectory, Path.GetFileName(additionalFile)));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error copying additional game file(s).\n{ex.Message}",
                                "sWall Activity Manager",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            // Media
            if (mediaRadioButton.Checked)
            {
                try
                {
                    File.Copy(videoTextBox.Text, Path.Combine(activityDirectory, Path.GetFileName(videoTextBox.Text)));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error copying video file.\n{ex.Message}",
                        "sWall Activity Manager",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
            }

            // Add the activity to the xml
            AddActivityToXml();
        }

        /// <summary>
        /// Find the activity currently selected in the list box and deletes it from the xml.
        /// </summary>
        private void DeleteActivity()
        {
            // Delete activity directory and all sub-directories/files
            Directory.Delete(Path.Combine(activitiesDirectoryPath, activitiesListBox.SelectedItem.ToString()), true);

            // Delete activity entry in xml
            foreach (XmlNode node in activitySet.SelectNodes("/Activities/Activity"))
            {
                if (node["Name"].InnerText.Equals(activitiesListBox.SelectedItem.ToString()))
                {
                    node.ParentNode.RemoveChild(node);
                    activitySet.Save(activitySetFilePath);
                }
            }
        }

        private void AddActivityToXml()
        {
            // Note: Order is this way because of how the activitySet.xml file was originally organized

            XmlNode root = activitySet.DocumentElement;

            // Create a new node and add all the fields
            XmlElement activityElement = activitySet.CreateElement("Activity");

            // Date stamp
            XmlComment commentElement = activitySet.CreateComment($"Added by sWall Activity Manager on {DateTime.Now.ToString()}");

            // Name
            XmlElement nameElement = activitySet.CreateElement("Name");
            nameElement.InnerText = nameTextBox.Text;

            // Thumbnail
            XmlElement imageLocationElement = activitySet.CreateElement("ImageLocation");
            imageLocationElement.InnerText = Path.GetFileName(thumbnailTextBox.Text);

            // Description
            XmlElement descriptionElement = activitySet.CreateElement("Description");
            descriptionElement.InnerText = descriptionTextBox.Text;

            // Tags
            XmlElement tagsElement = activitySet.CreateElement("Tags");
            XmlElement tagElement;

            // Separate tag string[] into individual strings and create a node for each
            foreach (string tag in tagsTextBox.Lines)
            {
                tagElement = activitySet.CreateElement("Tag");
                tagElement.InnerText = tag;
                tagsElement.AppendChild(tagElement);
            }

            // Append child elements to the activity element
            activityElement.AppendChild(commentElement);
            activityElement.AppendChild(nameElement);
            activityElement.AppendChild(imageLocationElement);

            // Elements used by all activity types
            XmlElement typeElement = activitySet.CreateElement("Type");
            XmlElement fileElement = activitySet.CreateElement("File");
            XmlElement filesElement = activitySet.CreateElement("Files");

            // Elements used only by media types
            XmlElement resolutionElement = activitySet.CreateElement("Resolution");
            XmlElement widthElement = activitySet.CreateElement("Width");
            XmlElement heightElement = activitySet.CreateElement("Height");

            // Elements used only by browser types
            XmlElement urlElement = activitySet.CreateElement("Url");

            // Game
            // Note: Do not need to add additional files here, only the executable
            if (gameRadioButton.Checked)
            {
                typeElement.InnerText = "Game";

                // Game executable
                fileElement = activitySet.CreateElement("File");
                fileElement.InnerText = Path.GetFileName(gameExecutableTextBox.Text);
                filesElement.AppendChild(fileElement);
            }

            // Media
            else if (mediaRadioButton.Checked)
            {
                typeElement.InnerText = "Media";

                fileElement.InnerText = Path.GetFileName(videoTextBox.Text);

                widthElement.InnerText = videoWidthTextBox.Text;
                resolutionElement.AppendChild(widthElement);

                heightElement.InnerText = videoHeightTextBox.Text;
                resolutionElement.AppendChild(heightElement);
            }

            // Browser
            else
            {
                typeElement.InnerText = "Browser";

                fileElement.InnerText = "Browser.exe";

                urlElement.InnerText = urlTextBox.Text;
            }
            filesElement.AppendChild(fileElement);

            activityElement.AppendChild(typeElement);
            activityElement.AppendChild(tagsElement);
            activityElement.AppendChild(descriptionElement);
            activityElement.AppendChild(filesElement);
            if (mediaRadioButton.Checked) activityElement.AppendChild(resolutionElement);
            else if (browserRadioButton.Checked) activityElement.AppendChild(urlElement);

            // Add the node to the document and save it
            root.PrependChild(activityElement);
            activitySet.Save(activitySetFilePath);
        }

        private void ClearFields()
        {
            nameTextBox.Text = String.Empty;
            descriptionTextBox.Text = String.Empty;
            tagsTextBox.Text = String.Empty;
            thumbnailTextBox.Text = String.Empty;

            gameExecutableTextBox.Text = String.Empty;
            additionalGameFilesTextBox.Text = String.Empty;

            videoTextBox.Text = String.Empty;
            videoHeightTextBox.Text = String.Empty;
            videoWidthTextBox.Text = String.Empty;

            urlTextBox.Text = String.Empty;
        }
    }
}
