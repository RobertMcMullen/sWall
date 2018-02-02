namespace sWall_Activity_Manager
{
    partial class SWallForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SWallForm));
            this.additionalGameFilesFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openThumbnailFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openGameExecutableFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openVideoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.miscellaneousTabPage = new System.Windows.Forms.TabPage();
            this.activitySetFilePathLabel = new System.Windows.Forms.Label();
            this.activitySetFilePathTextBox = new System.Windows.Forms.TextBox();
            this.aboutGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.tagsLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.thumbnailLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.thumbnailTextBox = new System.Windows.Forms.TextBox();
            this.browseThumbnailButton = new System.Windows.Forms.Button();
            this.browserGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.mediaGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.videoLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.browseVideoButton = new System.Windows.Forms.Button();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.videoHeightLabel = new System.Windows.Forms.Label();
            this.videoHeightTextBox = new System.Windows.Forms.TextBox();
            this.videoWidthLabel = new System.Windows.Forms.Label();
            this.videoWidthTextBox = new System.Windows.Forms.TextBox();
            this.gameGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.additionalGameFilesCheckBox = new System.Windows.Forms.CheckBox();
            this.gameExecutableLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.gameExecutableTextBox = new System.Windows.Forms.TextBox();
            this.browseGameExecutableButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.additionalGameFilesFolderTextBox = new System.Windows.Forms.TextBox();
            this.browseAdditionalGameFilesFolderButton = new System.Windows.Forms.Button();
            this.activityGroupBox = new System.Windows.Forms.GroupBox();
            this.browserRadioButton = new System.Windows.Forms.RadioButton();
            this.mediaRadioButton = new System.Windows.Forms.RadioButton();
            this.gameRadioButton = new System.Windows.Forms.RadioButton();
            this.addButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.activitiesDirectoryPathTextBox = new System.Windows.Forms.TextBox();
            this.activitiesDirectoryPathLabel = new System.Windows.Forms.Label();
            this.miscellaneousTabPage.SuspendLayout();
            this.addTabPage.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.browserGroupBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.mediaGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.gameGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.activityGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // openThumbnailFileDialog
            // 
            this.openThumbnailFileDialog.Filter = "Image Files (*.PNG;*.JPG)|*.PNG;*.JPG";
            this.openThumbnailFileDialog.RestoreDirectory = true;
            // 
            // openGameExecutableFileDialog
            // 
            this.openGameExecutableFileDialog.Filter = "Executable Files (*.exe)|*.exe";
            // 
            // openVideoFileDialog
            // 
            this.openVideoFileDialog.Filter = "Video file (*.mp4)|*.mp4";
            // 
            // miscellaneousTabPage
            // 
            this.miscellaneousTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.miscellaneousTabPage.Controls.Add(this.settingsGroupBox);
            this.miscellaneousTabPage.Controls.Add(this.aboutGroupBox);
            this.miscellaneousTabPage.Controls.Add(this.groupBox1);
            this.miscellaneousTabPage.Location = new System.Drawing.Point(4, 22);
            this.miscellaneousTabPage.Name = "miscellaneousTabPage";
            this.miscellaneousTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.miscellaneousTabPage.Size = new System.Drawing.Size(576, 550);
            this.miscellaneousTabPage.TabIndex = 1;
            this.miscellaneousTabPage.Text = "Misc.";
            // 
            // activitySetFilePathLabel
            // 
            this.activitySetFilePathLabel.AutoSize = true;
            this.activitySetFilePathLabel.Location = new System.Drawing.Point(3, 6);
            this.activitySetFilePathLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.activitySetFilePathLabel.Name = "activitySetFilePathLabel";
            this.activitySetFilePathLabel.Size = new System.Drawing.Size(60, 13);
            this.activitySetFilePathLabel.TabIndex = 1;
            this.activitySetFilePathLabel.Text = "Activity Set";
            // 
            // activitySetFilePathTextBox
            // 
            this.activitySetFilePathTextBox.Location = new System.Drawing.Point(90, 3);
            this.activitySetFilePathTextBox.Name = "activitySetFilePathTextBox";
            this.activitySetFilePathTextBox.Size = new System.Drawing.Size(458, 20);
            this.activitySetFilePathTextBox.TabIndex = 0;
            this.activitySetFilePathTextBox.TextChanged += new System.EventHandler(this.activitySetFilePathTextBox_TextChanged);
            // 
            // aboutGroupBox
            // 
            this.aboutGroupBox.Location = new System.Drawing.Point(6, 90);
            this.aboutGroupBox.Name = "aboutGroupBox";
            this.aboutGroupBox.Size = new System.Drawing.Size(564, 262);
            this.aboutGroupBox.TabIndex = 1;
            this.aboutGroupBox.TabStop = false;
            this.aboutGroupBox.Text = "About";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instructions";
            // 
            // addTabPage
            // 
            this.addTabPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addTabPage.Controls.Add(this.generalGroupBox);
            this.addTabPage.Controls.Add(this.browserGroupBox);
            this.addTabPage.Controls.Add(this.mediaGroupBox);
            this.addTabPage.Controls.Add(this.gameGroupBox);
            this.addTabPage.Controls.Add(this.activityGroupBox);
            this.addTabPage.Controls.Add(this.addButton);
            this.addTabPage.Location = new System.Drawing.Point(4, 22);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(576, 550);
            this.addTabPage.TabIndex = 0;
            this.addTabPage.Text = "Add";
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.generalGroupBox.Location = new System.Drawing.Point(6, 54);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(564, 214);
            this.generalGroupBox.TabIndex = 1;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tagsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.titleTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.descriptionTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tagsTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.thumbnailLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 188);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(3, 6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 32);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 0;
            this.descriptionLabel.Text = "Description";
            // 
            // tagsLabel
            // 
            this.tagsLabel.AutoSize = true;
            this.tagsLabel.Location = new System.Drawing.Point(3, 98);
            this.tagsLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.tagsLabel.Name = "tagsLabel";
            this.tagsLabel.Size = new System.Drawing.Size(31, 13);
            this.tagsLabel.TabIndex = 0;
            this.tagsLabel.Text = "Tags";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.titleTextBox.Location = new System.Drawing.Point(69, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(480, 20);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descriptionTextBox.Location = new System.Drawing.Point(69, 29);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(480, 60);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tagsTextBox.Location = new System.Drawing.Point(69, 95);
            this.tagsTextBox.Multiline = true;
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(480, 60);
            this.tagsTextBox.TabIndex = 3;
            // 
            // thumbnailLabel
            // 
            this.thumbnailLabel.AutoSize = true;
            this.thumbnailLabel.Location = new System.Drawing.Point(3, 164);
            this.thumbnailLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.thumbnailLabel.Name = "thumbnailLabel";
            this.thumbnailLabel.Size = new System.Drawing.Size(56, 13);
            this.thumbnailLabel.TabIndex = 0;
            this.thumbnailLabel.Text = "Thumbnail";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.thumbnailTextBox);
            this.flowLayoutPanel1.Controls.Add(this.browseThumbnailButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(66, 158);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(486, 30);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // thumbnailTextBox
            // 
            this.thumbnailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.thumbnailTextBox.Location = new System.Drawing.Point(3, 4);
            this.thumbnailTextBox.Name = "thumbnailTextBox";
            this.thumbnailTextBox.Size = new System.Drawing.Size(399, 20);
            this.thumbnailTextBox.TabIndex = 1;
            // 
            // browseThumbnailButton
            // 
            this.browseThumbnailButton.Location = new System.Drawing.Point(408, 3);
            this.browseThumbnailButton.Name = "browseThumbnailButton";
            this.browseThumbnailButton.Size = new System.Drawing.Size(75, 23);
            this.browseThumbnailButton.TabIndex = 2;
            this.browseThumbnailButton.Text = "Browse...";
            this.browseThumbnailButton.UseVisualStyleBackColor = true;
            this.browseThumbnailButton.Click += new System.EventHandler(this.browseThumbnailButton_Click);
            // 
            // browserGroupBox
            // 
            this.browserGroupBox.Controls.Add(this.tableLayoutPanel4);
            this.browserGroupBox.Location = new System.Drawing.Point(6, 461);
            this.browserGroupBox.Name = "browserGroupBox";
            this.browserGroupBox.Size = new System.Drawing.Size(564, 52);
            this.browserGroupBox.TabIndex = 4;
            this.browserGroupBox.TabStop = false;
            this.browserGroupBox.Text = "Browser";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.urlLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.urlTextBox, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(552, 26);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(3, 6);
            this.urlLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(29, 13);
            this.urlLabel.TabIndex = 0;
            this.urlLabel.Text = "URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(38, 3);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(511, 20);
            this.urlTextBox.TabIndex = 1;
            // 
            // mediaGroupBox
            // 
            this.mediaGroupBox.Controls.Add(this.tableLayoutPanel3);
            this.mediaGroupBox.Location = new System.Drawing.Point(6, 367);
            this.mediaGroupBox.Name = "mediaGroupBox";
            this.mediaGroupBox.Size = new System.Drawing.Size(564, 88);
            this.mediaGroupBox.TabIndex = 3;
            this.mediaGroupBox.TabStop = false;
            this.mediaGroupBox.Text = "Media";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.videoLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.resolutionLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(552, 61);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // videoLabel
            // 
            this.videoLabel.AutoSize = true;
            this.videoLabel.Location = new System.Drawing.Point(3, 6);
            this.videoLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.videoLabel.Name = "videoLabel";
            this.videoLabel.Size = new System.Drawing.Size(34, 13);
            this.videoLabel.TabIndex = 0;
            this.videoLabel.Text = "Video";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.videoTextBox);
            this.flowLayoutPanel4.Controls.Add(this.browseVideoButton);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(63, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(489, 30);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // videoTextBox
            // 
            this.videoTextBox.Location = new System.Drawing.Point(3, 3);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.Size = new System.Drawing.Size(402, 20);
            this.videoTextBox.TabIndex = 1;
            // 
            // browseVideoButton
            // 
            this.browseVideoButton.Location = new System.Drawing.Point(411, 3);
            this.browseVideoButton.Name = "browseVideoButton";
            this.browseVideoButton.Size = new System.Drawing.Size(75, 23);
            this.browseVideoButton.TabIndex = 2;
            this.browseVideoButton.Text = "Browse...";
            this.browseVideoButton.UseVisualStyleBackColor = true;
            this.browseVideoButton.Click += new System.EventHandler(this.browseVideoButton_Click);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(3, 36);
            this.resolutionLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.resolutionLabel.TabIndex = 0;
            this.resolutionLabel.Text = "Resolution";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.videoHeightLabel);
            this.flowLayoutPanel5.Controls.Add(this.videoHeightTextBox);
            this.flowLayoutPanel5.Controls.Add(this.videoWidthLabel);
            this.flowLayoutPanel5.Controls.Add(this.videoWidthTextBox);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(63, 30);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(489, 31);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // videoHeightLabel
            // 
            this.videoHeightLabel.AutoSize = true;
            this.videoHeightLabel.Location = new System.Drawing.Point(3, 6);
            this.videoHeightLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.videoHeightLabel.Name = "videoHeightLabel";
            this.videoHeightLabel.Size = new System.Drawing.Size(38, 13);
            this.videoHeightLabel.TabIndex = 0;
            this.videoHeightLabel.Text = "Height";
            // 
            // videoHeightTextBox
            // 
            this.videoHeightTextBox.Location = new System.Drawing.Point(47, 3);
            this.videoHeightTextBox.Name = "videoHeightTextBox";
            this.videoHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.videoHeightTextBox.TabIndex = 2;
            this.videoHeightTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // videoWidthLabel
            // 
            this.videoWidthLabel.AutoSize = true;
            this.videoWidthLabel.Location = new System.Drawing.Point(153, 6);
            this.videoWidthLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.videoWidthLabel.Name = "videoWidthLabel";
            this.videoWidthLabel.Size = new System.Drawing.Size(35, 13);
            this.videoWidthLabel.TabIndex = 0;
            this.videoWidthLabel.Text = "Width";
            // 
            // videoWidthTextBox
            // 
            this.videoWidthTextBox.Location = new System.Drawing.Point(194, 3);
            this.videoWidthTextBox.Name = "videoWidthTextBox";
            this.videoWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.videoWidthTextBox.TabIndex = 3;
            this.videoWidthTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gameGroupBox
            // 
            this.gameGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.gameGroupBox.Location = new System.Drawing.Point(6, 274);
            this.gameGroupBox.Name = "gameGroupBox";
            this.gameGroupBox.Size = new System.Drawing.Size(564, 87);
            this.gameGroupBox.TabIndex = 2;
            this.gameGroupBox.TabStop = false;
            this.gameGroupBox.Text = " Game";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.additionalGameFilesCheckBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gameExecutableLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(552, 61);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // additionalGameFilesCheckBox
            // 
            this.additionalGameFilesCheckBox.AutoSize = true;
            this.additionalGameFilesCheckBox.Location = new System.Drawing.Point(3, 36);
            this.additionalGameFilesCheckBox.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.additionalGameFilesCheckBox.Name = "additionalGameFilesCheckBox";
            this.additionalGameFilesCheckBox.Size = new System.Drawing.Size(93, 17);
            this.additionalGameFilesCheckBox.TabIndex = 3;
            this.additionalGameFilesCheckBox.Text = "Additional files";
            this.additionalGameFilesCheckBox.UseVisualStyleBackColor = true;
            this.additionalGameFilesCheckBox.CheckedChanged += new System.EventHandler(this.additionalGameFilescheckBox_CheckedChanged);
            // 
            // gameExecutableLabel
            // 
            this.gameExecutableLabel.AutoSize = true;
            this.gameExecutableLabel.Location = new System.Drawing.Point(3, 6);
            this.gameExecutableLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.gameExecutableLabel.Name = "gameExecutableLabel";
            this.gameExecutableLabel.Size = new System.Drawing.Size(60, 13);
            this.gameExecutableLabel.TabIndex = 0;
            this.gameExecutableLabel.Text = "Executable";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.gameExecutableTextBox);
            this.flowLayoutPanel3.Controls.Add(this.browseGameExecutableButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(99, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(453, 30);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // gameExecutableTextBox
            // 
            this.gameExecutableTextBox.Location = new System.Drawing.Point(3, 3);
            this.gameExecutableTextBox.Name = "gameExecutableTextBox";
            this.gameExecutableTextBox.Size = new System.Drawing.Size(366, 20);
            this.gameExecutableTextBox.TabIndex = 1;
            // 
            // browseGameExecutableButton
            // 
            this.browseGameExecutableButton.Location = new System.Drawing.Point(375, 3);
            this.browseGameExecutableButton.Name = "browseGameExecutableButton";
            this.browseGameExecutableButton.Size = new System.Drawing.Size(75, 23);
            this.browseGameExecutableButton.TabIndex = 2;
            this.browseGameExecutableButton.Text = "Browse...";
            this.browseGameExecutableButton.UseVisualStyleBackColor = true;
            this.browseGameExecutableButton.Click += new System.EventHandler(this.browseGameExecutableButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.additionalGameFilesFolderTextBox);
            this.flowLayoutPanel2.Controls.Add(this.browseAdditionalGameFilesFolderButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(99, 30);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(453, 30);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // additionalGameFilesFolderTextBox
            // 
            this.additionalGameFilesFolderTextBox.AllowDrop = true;
            this.additionalGameFilesFolderTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.additionalGameFilesFolderTextBox.Enabled = false;
            this.additionalGameFilesFolderTextBox.Location = new System.Drawing.Point(3, 4);
            this.additionalGameFilesFolderTextBox.Name = "additionalGameFilesFolderTextBox";
            this.additionalGameFilesFolderTextBox.Size = new System.Drawing.Size(366, 20);
            this.additionalGameFilesFolderTextBox.TabIndex = 1;
            this.additionalGameFilesFolderTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.gameFolderTextBox_DragDrop);
            // 
            // browseAdditionalGameFilesFolderButton
            // 
            this.browseAdditionalGameFilesFolderButton.Enabled = false;
            this.browseAdditionalGameFilesFolderButton.Location = new System.Drawing.Point(375, 3);
            this.browseAdditionalGameFilesFolderButton.Name = "browseAdditionalGameFilesFolderButton";
            this.browseAdditionalGameFilesFolderButton.Size = new System.Drawing.Size(75, 23);
            this.browseAdditionalGameFilesFolderButton.TabIndex = 2;
            this.browseAdditionalGameFilesFolderButton.Text = "Browse...";
            this.browseAdditionalGameFilesFolderButton.UseVisualStyleBackColor = true;
            this.browseAdditionalGameFilesFolderButton.Click += new System.EventHandler(this.browseAdditionalGameFilesFolderButton_Click);
            // 
            // activityGroupBox
            // 
            this.activityGroupBox.Controls.Add(this.browserRadioButton);
            this.activityGroupBox.Controls.Add(this.mediaRadioButton);
            this.activityGroupBox.Controls.Add(this.gameRadioButton);
            this.activityGroupBox.Location = new System.Drawing.Point(6, 6);
            this.activityGroupBox.Name = "activityGroupBox";
            this.activityGroupBox.Size = new System.Drawing.Size(564, 42);
            this.activityGroupBox.TabIndex = 0;
            this.activityGroupBox.TabStop = false;
            this.activityGroupBox.Text = "Activity type";
            // 
            // browserRadioButton
            // 
            this.browserRadioButton.AutoSize = true;
            this.browserRadioButton.Location = new System.Drawing.Point(125, 19);
            this.browserRadioButton.Name = "browserRadioButton";
            this.browserRadioButton.Size = new System.Drawing.Size(63, 17);
            this.browserRadioButton.TabIndex = 2;
            this.browserRadioButton.TabStop = true;
            this.browserRadioButton.Text = "Browser";
            this.browserRadioButton.UseVisualStyleBackColor = true;
            this.browserRadioButton.CheckedChanged += new System.EventHandler(this.browserRadioButton_CheckedChanged);
            // 
            // mediaRadioButton
            // 
            this.mediaRadioButton.AutoSize = true;
            this.mediaRadioButton.Location = new System.Drawing.Point(65, 19);
            this.mediaRadioButton.Name = "mediaRadioButton";
            this.mediaRadioButton.Size = new System.Drawing.Size(54, 17);
            this.mediaRadioButton.TabIndex = 1;
            this.mediaRadioButton.TabStop = true;
            this.mediaRadioButton.Text = "Media";
            this.mediaRadioButton.UseVisualStyleBackColor = true;
            this.mediaRadioButton.CheckedChanged += new System.EventHandler(this.mediaRadioButton_CheckedChanged);
            // 
            // gameRadioButton
            // 
            this.gameRadioButton.AutoSize = true;
            this.gameRadioButton.Location = new System.Drawing.Point(6, 19);
            this.gameRadioButton.Name = "gameRadioButton";
            this.gameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.gameRadioButton.TabIndex = 0;
            this.gameRadioButton.TabStop = true;
            this.gameRadioButton.Text = "Game";
            this.gameRadioButton.UseVisualStyleBackColor = true;
            this.gameRadioButton.CheckedChanged += new System.EventHandler(this.gameRadioButton_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addButton.Location = new System.Drawing.Point(486, 519);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add activity";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.addTabPage);
            this.tabControl.Controls.Add(this.miscellaneousTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(584, 576);
            this.tabControl.TabIndex = 3;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.tableLayoutPanel5);
            this.settingsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(564, 78);
            this.settingsGroupBox.TabIndex = 4;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.activitySetFilePathTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.activitySetFilePathLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.activitiesDirectoryPathTextBox, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.activitiesDirectoryPathLabel, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(7, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(551, 52);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // activitiesDirectoryPathTextBox
            // 
            this.activitiesDirectoryPathTextBox.Location = new System.Drawing.Point(90, 29);
            this.activitiesDirectoryPathTextBox.Name = "activitiesDirectoryPathTextBox";
            this.activitiesDirectoryPathTextBox.Size = new System.Drawing.Size(458, 20);
            this.activitiesDirectoryPathTextBox.TabIndex = 2;
            this.activitiesDirectoryPathTextBox.TextChanged += new System.EventHandler(this.activitiesDirectoryPathTextBox_TextChanged);
            // 
            // activitiesDirectoryPathLabel
            // 
            this.activitiesDirectoryPathLabel.AutoSize = true;
            this.activitiesDirectoryPathLabel.Location = new System.Drawing.Point(3, 32);
            this.activitiesDirectoryPathLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.activitiesDirectoryPathLabel.Name = "activitiesDirectoryPathLabel";
            this.activitiesDirectoryPathLabel.Size = new System.Drawing.Size(81, 13);
            this.activitiesDirectoryPathLabel.TabIndex = 3;
            this.activitiesDirectoryPathLabel.Text = "Activities Folder";
            // 
            // SWallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 576);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SWallForm";
            this.Text = "sWall Activity Manager";
            this.Load += new System.EventHandler(this.sWallForm_Load);
            this.miscellaneousTabPage.ResumeLayout(false);
            this.addTabPage.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.browserGroupBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.mediaGroupBox.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.gameGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.activityGroupBox.ResumeLayout(false);
            this.activityGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog additionalGameFilesFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openThumbnailFileDialog;
        private System.Windows.Forms.OpenFileDialog openGameExecutableFileDialog;
        private System.Windows.Forms.OpenFileDialog openVideoFileDialog;
        private System.Windows.Forms.TabPage miscellaneousTabPage;
        private System.Windows.Forms.GroupBox aboutGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage addTabPage;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label tagsLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.Label thumbnailLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox thumbnailTextBox;
        private System.Windows.Forms.Button browseThumbnailButton;
        private System.Windows.Forms.GroupBox browserGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.GroupBox mediaGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label videoLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox videoTextBox;
        private System.Windows.Forms.Button browseVideoButton;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label videoHeightLabel;
        private System.Windows.Forms.TextBox videoHeightTextBox;
        private System.Windows.Forms.Label videoWidthLabel;
        private System.Windows.Forms.TextBox videoWidthTextBox;
        private System.Windows.Forms.GroupBox gameGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox additionalGameFilesCheckBox;
        private System.Windows.Forms.Label gameExecutableLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox gameExecutableTextBox;
        private System.Windows.Forms.Button browseGameExecutableButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox additionalGameFilesFolderTextBox;
        private System.Windows.Forms.Button browseAdditionalGameFilesFolderButton;
        private System.Windows.Forms.GroupBox activityGroupBox;
        private System.Windows.Forms.RadioButton browserRadioButton;
        private System.Windows.Forms.RadioButton mediaRadioButton;
        private System.Windows.Forms.RadioButton gameRadioButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox activitySetFilePathTextBox;
        private System.Windows.Forms.Label activitySetFilePathLabel;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox activitiesDirectoryPathTextBox;
        private System.Windows.Forms.Label activitiesDirectoryPathLabel;
    }
}

