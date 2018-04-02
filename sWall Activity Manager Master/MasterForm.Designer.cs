namespace sWallActivityManager
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.submitButton = new System.Windows.Forms.Button();
            this.gameExecutableTextBox = new System.Windows.Forms.TextBox();
            this.activitiesListBox = new System.Windows.Forms.ListBox();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.additionalGameFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.browseAdditionalGameFilesButton = new System.Windows.Forms.Button();
            this.additionalGameFilesTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.gameLabel = new System.Windows.Forms.Label();
            this.browseGameExecutableButton = new System.Windows.Forms.Button();
            this.mediaGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.browseVideoButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.heightLabel = new System.Windows.Forms.Label();
            this.videoHeightTextBox = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.videoWidthTextBox = new System.Windows.Forms.TextBox();
            this.browserGroupBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.openThumbnailFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gameRadioButton = new System.Windows.Forms.RadioButton();
            this.mediaRadioButton = new System.Windows.Forms.RadioButton();
            this.browserRadioButton = new System.Windows.Forms.RadioButton();
            this.openGameExecutableFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openVideoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.editActivitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addRadioButton = new System.Windows.Forms.RadioButton();
            this.editRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.thumbnailTextBox = new System.Windows.Forms.TextBox();
            this.browseThumbnailButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.thumbnailLabel = new System.Windows.Forms.Label();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.typeGroupBox = new System.Windows.Forms.GroupBox();
            this.openAdditionalGameFilesDialog = new System.Windows.Forms.OpenFileDialog();
            this.gameGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.mediaGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.browserGroupBox.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.editActivitiesGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.typeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(1204, 925);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(113, 51);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // gameExecutableTextBox
            // 
            this.gameExecutableTextBox.Location = new System.Drawing.Point(112, 3);
            this.gameExecutableTextBox.Name = "gameExecutableTextBox";
            this.gameExecutableTextBox.Size = new System.Drawing.Size(578, 31);
            this.gameExecutableTextBox.TabIndex = 1;
            // 
            // activitiesListBox
            // 
            this.activitiesListBox.FormattingEnabled = true;
            this.activitiesListBox.ItemHeight = 25;
            this.activitiesListBox.Location = new System.Drawing.Point(6, 30);
            this.activitiesListBox.Name = "activitiesListBox";
            this.activitiesListBox.Size = new System.Drawing.Size(411, 829);
            this.activitiesListBox.TabIndex = 1;
            this.activitiesListBox.SelectedIndexChanged += new System.EventHandler(this.ActivitiesListBox_SelectedIndexChanged);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.gameGroupBox.Location = new System.Drawing.Point(457, 471);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(860, 208);
            this.gameGroupBox.TabIndex = 6;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = "Game";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(848, 171);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel3.Controls.Add(this.additionalGameFilesTextBox);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(848, 120);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.additionalGameFilesCheckBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.browseAdditionalGameFilesButton, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // additionalGameFilesCheckBox
            // 
            this.additionalGameFilesCheckBox.AutoSize = true;
            this.additionalGameFilesCheckBox.Location = new System.Drawing.Point(3, 3);
            this.additionalGameFilesCheckBox.Name = "additionalGameFilesCheckBox";
            this.additionalGameFilesCheckBox.Size = new System.Drawing.Size(184, 29);
            this.additionalGameFilesCheckBox.TabIndex = 3;
            this.additionalGameFilesCheckBox.Text = "Additional files";
            this.additionalGameFilesCheckBox.UseVisualStyleBackColor = true;
            this.additionalGameFilesCheckBox.CheckedChanged += new System.EventHandler(this.AdditionalGameFilescheckBox_CheckedChanged);
            // 
            // browseAdditionalGameFilesButton
            // 
            this.browseAdditionalGameFilesButton.Enabled = false;
            this.browseAdditionalGameFilesButton.Location = new System.Drawing.Point(3, 53);
            this.browseAdditionalGameFilesButton.Name = "browseAdditionalGameFilesButton";
            this.browseAdditionalGameFilesButton.Size = new System.Drawing.Size(114, 38);
            this.browseAdditionalGameFilesButton.TabIndex = 5;
            this.browseAdditionalGameFilesButton.Text = "Browse...";
            this.browseAdditionalGameFilesButton.UseVisualStyleBackColor = true;
            this.browseAdditionalGameFilesButton.Click += new System.EventHandler(this.BrowseAdditionalGameFilesButton_Click);
            // 
            // additionalGameFilesTextBox
            // 
            this.additionalGameFilesTextBox.Enabled = false;
            this.additionalGameFilesTextBox.Location = new System.Drawing.Point(209, 3);
            this.additionalGameFilesTextBox.Multiline = true;
            this.additionalGameFilesTextBox.Name = "additionalGameFilesTextBox";
            this.additionalGameFilesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.additionalGameFilesTextBox.Size = new System.Drawing.Size(601, 110);
            this.additionalGameFilesTextBox.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.gameLabel);
            this.flowLayoutPanel2.Controls.Add(this.gameExecutableTextBox);
            this.flowLayoutPanel2.Controls.Add(this.browseGameExecutableButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(848, 50);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(3, 0);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(103, 25);
            this.gameLabel.TabIndex = 23;
            this.gameLabel.Text = "Game file";
            this.gameLabel.UseWaitCursor = true;
            // 
            // browseGameExecutableButton
            // 
            this.browseGameExecutableButton.Location = new System.Drawing.Point(696, 3);
            this.browseGameExecutableButton.Name = "browseGameExecutableButton";
            this.browseGameExecutableButton.Size = new System.Drawing.Size(114, 38);
            this.browseGameExecutableButton.TabIndex = 2;
            this.browseGameExecutableButton.Text = "Browse...";
            this.browseGameExecutableButton.UseVisualStyleBackColor = true;
            this.browseGameExecutableButton.Click += new System.EventHandler(this.BrowseGameExecutableButton_Click);
            // 
            // mediaGroupBox
            // 
            this.mediaGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.mediaGroupBox.Enabled = false;
            this.mediaGroupBox.Location = new System.Drawing.Point(457, 685);
            this.mediaGroupBox.Name = "mediaGroupBox";
            this.mediaGroupBox.Size = new System.Drawing.Size(860, 134);
            this.mediaGroupBox.TabIndex = 7;
            this.mediaGroupBox.TabStop = false;
            this.mediaGroupBox.Text = "Media";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(845, 100);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label1);
            this.flowLayoutPanel5.Controls.Add(this.videoTextBox);
            this.flowLayoutPanel5.Controls.Add(this.browseVideoButton);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(845, 50);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Video file";
            // 
            // videoTextBox
            // 
            this.videoTextBox.Location = new System.Drawing.Point(110, 3);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.Size = new System.Drawing.Size(580, 31);
            this.videoTextBox.TabIndex = 1;
            // 
            // browseVideoButton
            // 
            this.browseVideoButton.Location = new System.Drawing.Point(696, 3);
            this.browseVideoButton.Name = "browseVideoButton";
            this.browseVideoButton.Size = new System.Drawing.Size(114, 38);
            this.browseVideoButton.TabIndex = 2;
            this.browseVideoButton.Text = "Browse...";
            this.browseVideoButton.UseVisualStyleBackColor = true;
            this.browseVideoButton.Click += new System.EventHandler(this.BrowseVideoButton_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.heightLabel);
            this.flowLayoutPanel4.Controls.Add(this.videoHeightTextBox);
            this.flowLayoutPanel4.Controls.Add(this.widthLabel);
            this.flowLayoutPanel4.Controls.Add(this.videoWidthTextBox);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(845, 50);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(3, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(74, 25);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "Height";
            // 
            // videoHeightTextBox
            // 
            this.videoHeightTextBox.Location = new System.Drawing.Point(83, 3);
            this.videoHeightTextBox.Name = "videoHeightTextBox";
            this.videoHeightTextBox.Size = new System.Drawing.Size(100, 31);
            this.videoHeightTextBox.TabIndex = 3;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(189, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(67, 25);
            this.widthLabel.TabIndex = 14;
            this.widthLabel.Text = "Width";
            // 
            // videoWidthTextBox
            // 
            this.videoWidthTextBox.Location = new System.Drawing.Point(262, 3);
            this.videoWidthTextBox.Name = "videoWidthTextBox";
            this.videoWidthTextBox.Size = new System.Drawing.Size(100, 31);
            this.videoWidthTextBox.TabIndex = 4;
            // 
            // browserGroupBox
            // 
            this.browserGroupBox.Controls.Add(this.flowLayoutPanel6);
            this.browserGroupBox.Enabled = false;
            this.browserGroupBox.Location = new System.Drawing.Point(457, 825);
            this.browserGroupBox.Name = "browserGroupBox";
            this.browserGroupBox.Size = new System.Drawing.Size(860, 94);
            this.browserGroupBox.TabIndex = 8;
            this.browserGroupBox.TabStop = false;
            this.browserGroupBox.Text = "Browser";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.UrlLabel);
            this.flowLayoutPanel6.Controls.Add(this.urlTextBox);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(6, 30);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(845, 58);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Location = new System.Drawing.Point(6, 3);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(39, 25);
            this.UrlLabel.TabIndex = 14;
            this.UrlLabel.Text = "Url";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(51, 6);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(759, 31);
            this.urlTextBox.TabIndex = 1;
            // 
            // openThumbnailFileDialog
            // 
            this.openThumbnailFileDialog.Filter = "Image Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            this.openThumbnailFileDialog.Title = "Thumbnail";
            // 
            // gameRadioButton
            // 
            this.gameRadioButton.AutoSize = true;
            this.gameRadioButton.Checked = true;
            this.gameRadioButton.Location = new System.Drawing.Point(6, 30);
            this.gameRadioButton.Name = "gameRadioButton";
            this.gameRadioButton.Size = new System.Drawing.Size(100, 29);
            this.gameRadioButton.TabIndex = 1;
            this.gameRadioButton.TabStop = true;
            this.gameRadioButton.Text = "Game";
            this.gameRadioButton.UseVisualStyleBackColor = true;
            this.gameRadioButton.CheckedChanged += new System.EventHandler(this.GameRadioButton_CheckedChanged);
            // 
            // mediaRadioButton
            // 
            this.mediaRadioButton.AutoSize = true;
            this.mediaRadioButton.Location = new System.Drawing.Point(112, 30);
            this.mediaRadioButton.Name = "mediaRadioButton";
            this.mediaRadioButton.Size = new System.Drawing.Size(102, 29);
            this.mediaRadioButton.TabIndex = 2;
            this.mediaRadioButton.Text = "Media";
            this.mediaRadioButton.UseVisualStyleBackColor = true;
            this.mediaRadioButton.CheckedChanged += new System.EventHandler(this.MediaRadioButton_CheckedChanged);
            // 
            // browserRadioButton
            // 
            this.browserRadioButton.AutoSize = true;
            this.browserRadioButton.Location = new System.Drawing.Point(220, 30);
            this.browserRadioButton.Name = "browserRadioButton";
            this.browserRadioButton.Size = new System.Drawing.Size(121, 29);
            this.browserRadioButton.TabIndex = 3;
            this.browserRadioButton.Text = "Browser";
            this.browserRadioButton.UseVisualStyleBackColor = true;
            this.browserRadioButton.CheckedChanged += new System.EventHandler(this.BrowserRadioButton_CheckedChanged);
            // 
            // openGameExecutableFileDialog
            // 
            this.openGameExecutableFileDialog.Filter = "Executable Files (.exe)|*.exe|All files (*.*)|*.*";
            this.openGameExecutableFileDialog.Title = "Game Executable";
            // 
            // openVideoFileDialog
            // 
            this.openVideoFileDialog.Filter = "Video Files (*.mp4)|*.mp4|All Files (*.*)|*.*";
            this.openVideoFileDialog.Title = "Video";
            // 
            // editActivitiesGroupBox
            // 
            this.editActivitiesGroupBox.Controls.Add(this.deleteButton);
            this.editActivitiesGroupBox.Controls.Add(this.activitiesListBox);
            this.editActivitiesGroupBox.Enabled = false;
            this.editActivitiesGroupBox.Location = new System.Drawing.Point(12, 47);
            this.editActivitiesGroupBox.Name = "editActivitiesGroupBox";
            this.editActivitiesGroupBox.Size = new System.Drawing.Size(430, 929);
            this.editActivitiesGroupBox.TabIndex = 3;
            this.editActivitiesGroupBox.TabStop = false;
            this.editActivitiesGroupBox.Text = "View Activities";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(299, 878);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 42);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addRadioButton
            // 
            this.addRadioButton.AutoSize = true;
            this.addRadioButton.Checked = true;
            this.addRadioButton.Location = new System.Drawing.Point(251, 12);
            this.addRadioButton.Name = "addRadioButton";
            this.addRadioButton.Size = new System.Drawing.Size(199, 29);
            this.addRadioButton.TabIndex = 2;
            this.addRadioButton.TabStop = true;
            this.addRadioButton.Text = "Add new activity";
            this.addRadioButton.UseVisualStyleBackColor = true;
            this.addRadioButton.CheckedChanged += new System.EventHandler(this.AddRadioButton_CheckedChanged);
            // 
            // editRadioButton
            // 
            this.editRadioButton.AutoSize = true;
            this.editRadioButton.Location = new System.Drawing.Point(12, 12);
            this.editRadioButton.Name = "editRadioButton";
            this.editRadioButton.Size = new System.Drawing.Size(233, 29);
            this.editRadioButton.TabIndex = 1;
            this.editRadioButton.Text = "Edit existing activity";
            this.editRadioButton.UseVisualStyleBackColor = true;
            this.editRadioButton.CheckedChanged += new System.EventHandler(this.EditRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tagsTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tagsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.thumbnailLabel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 335);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.thumbnailTextBox);
            this.flowLayoutPanel1.Controls.Add(this.browseThumbnailButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(126, 269);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(722, 66);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // thumbnailTextBox
            // 
            this.thumbnailTextBox.Location = new System.Drawing.Point(3, 3);
            this.thumbnailTextBox.Name = "thumbnailTextBox";
            this.thumbnailTextBox.Size = new System.Drawing.Size(561, 31);
            this.thumbnailTextBox.TabIndex = 4;
            // 
            // browseThumbnailButton
            // 
            this.browseThumbnailButton.Location = new System.Drawing.Point(570, 3);
            this.browseThumbnailButton.Name = "browseThumbnailButton";
            this.browseThumbnailButton.Size = new System.Drawing.Size(114, 38);
            this.browseThumbnailButton.TabIndex = 5;
            this.browseThumbnailButton.Text = "Browse...";
            this.browseThumbnailButton.UseVisualStyleBackColor = true;
            this.browseThumbnailButton.Click += new System.EventHandler(this.BrowseThumbnailButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameTextBox.Location = new System.Drawing.Point(129, 3);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(681, 31);
            this.nameTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.descriptionTextBox.Location = new System.Drawing.Point(129, 40);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(681, 110);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(129, 156);
            this.tagsTextBox.Multiline = true;
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tagsTextBox.Size = new System.Drawing.Size(681, 110);
            this.tagsTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 37);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(120, 25);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Location = new System.Drawing.Point(3, 153);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(60, 25);
            this.tagsLabel.TabIndex = 0;
            this.tagsLabel.Text = "Tags";
            // 
            // thumbnailLabel
            // 
            this.thumbnailLabel.AutoSize = true;
            this.thumbnailLabel.Location = new System.Drawing.Point(3, 269);
            this.thumbnailLabel.Name = "thumbnailLabel";
            this.thumbnailLabel.Size = new System.Drawing.Size(112, 25);
            this.thumbnailLabel.TabIndex = 0;
            this.thumbnailLabel.Text = "Thumbnail";
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.generalGroupBox.Location = new System.Drawing.Point(457, 94);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(860, 371);
            this.generalGroupBox.TabIndex = 5;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // typeGroupBox
            // 
            this.typeGroupBox.Controls.Add(this.gameRadioButton);
            this.typeGroupBox.Controls.Add(this.mediaRadioButton);
            this.typeGroupBox.Controls.Add(this.browserRadioButton);
            this.typeGroupBox.Location = new System.Drawing.Point(457, 12);
            this.typeGroupBox.Name = "typeGroupBox";
            this.typeGroupBox.Size = new System.Drawing.Size(860, 76);
            this.typeGroupBox.TabIndex = 4;
            this.typeGroupBox.TabStop = false;
            this.typeGroupBox.Text = "Activity Type";
            // 
            // openAdditionalGameFilesDialog
            // 
            this.openAdditionalGameFilesDialog.Filter = "All files|*.*";
            this.openAdditionalGameFilesDialog.Multiselect = true;
            this.openAdditionalGameFilesDialog.Title = "Additional Game Files";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 984);
            this.Controls.Add(this.typeGroupBox);
            this.Controls.Add(this.generalGroupBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.editRadioButton);
            this.Controls.Add(this.addRadioButton);
            this.Controls.Add(this.browserGroupBox);
            this.Controls.Add(this.editActivitiesGroupBox);
            this.Controls.Add(this.mediaGroupBox);
            this.Controls.Add(this.gameGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasterForm";
            this.Text = "sWall Activity Manager";
            this.gameGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.mediaGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.browserGroupBox.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.editActivitiesGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.generalGroupBox.ResumeLayout(false);
            this.typeGroupBox.ResumeLayout(false);
            this.typeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox gameExecutableTextBox;
        private System.Windows.Forms.ListBox activitiesListBox;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.GroupBox mediaGroupBox;
        private System.Windows.Forms.GroupBox browserGroupBox;
        private System.Windows.Forms.OpenFileDialog openThumbnailFileDialog;
        private System.Windows.Forms.TextBox additionalGameFilesTextBox;
        private System.Windows.Forms.TextBox videoWidthTextBox;
        private System.Windows.Forms.TextBox videoHeightTextBox;
        private System.Windows.Forms.TextBox videoTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.CheckBox additionalGameFilesCheckBox;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.RadioButton mediaRadioButton;
        private System.Windows.Forms.RadioButton browserRadioButton;
        private System.Windows.Forms.Button browseAdditionalGameFilesButton;
        private System.Windows.Forms.OpenFileDialog openGameExecutableFileDialog;
        private System.Windows.Forms.OpenFileDialog openVideoFileDialog;
        private System.Windows.Forms.GroupBox editActivitiesGroupBox;
        private System.Windows.Forms.RadioButton addRadioButton;
        private System.Windows.Forms.RadioButton editRadioButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.TextBox thumbnailTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.Label thumbnailLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button browseThumbnailButton;
        private System.Windows.Forms.Button browseGameExecutableButton;
        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Button browseVideoButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.GroupBox typeGroupBox;
        private System.Windows.Forms.OpenFileDialog openAdditionalGameFilesDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}

