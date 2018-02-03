using System;

namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sdbutton = new System.Windows.Forms.Button();
            this.dbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sdbar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nbutton = new System.Windows.Forms.Button();
            this.abutton = new System.Windows.Forms.Button();
            this.sabutton = new System.Windows.Forms.Button();
            this.nbar = new System.Windows.Forms.ProgressBar();
            this.dbar = new System.Windows.Forms.ProgressBar();
            this.abar = new System.Windows.Forms.ProgressBar();
            this.sabar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.sdlabel = new System.Windows.Forms.Label();
            this.dlabel = new System.Windows.Forms.Label();
            this.nlabel = new System.Windows.Forms.Label();
            this.alabel = new System.Windows.Forms.Label();
            this.salabel = new System.Windows.Forms.Label();
            this.tlabel = new System.Windows.Forms.Label();
            this.adminbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // sdbutton
            // 
            this.sdbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdbutton.Location = new System.Drawing.Point(126, 245);
            this.sdbutton.Name = "sdbutton";
            this.sdbutton.Size = new System.Drawing.Size(165, 32);
            this.sdbutton.TabIndex = 0;
            this.sdbutton.Text = "STRONGLY DISAGREE";
            this.sdbutton.UseVisualStyleBackColor = true;
            this.sdbutton.Visible = false;
            this.sdbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbutton
            // 
            this.dbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbutton.Location = new System.Drawing.Point(144, 336);
            this.dbutton.Name = "dbutton";
            this.dbutton.Size = new System.Drawing.Size(147, 60);
            this.dbutton.TabIndex = 1;
            this.dbutton.Text = "DISAGREE ";
            this.dbutton.UseVisualStyleBackColor = true;
            this.dbutton.Visible = false;
            this.dbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(262, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "DEFAULT TEXT. LOG ON AS ADMIN TO EDIT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sdbar
            // 
            this.sdbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sdbar.Location = new System.Drawing.Point(407, 239);
            this.sdbar.Name = "sdbar";
            this.sdbar.RightToLeftLayout = true;
            this.sdbar.Size = new System.Drawing.Size(566, 46);
            this.sdbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.sdbar.TabIndex = 3;
            this.sdbar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // nbutton
            // 
            this.nbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.nbutton.Location = new System.Drawing.Point(144, 446);
            this.nbutton.Name = "nbutton";
            this.nbutton.Size = new System.Drawing.Size(133, 59);
            this.nbutton.TabIndex = 4;
            this.nbutton.Text = "NEUTRAL";
            this.nbutton.UseVisualStyleBackColor = true;
            this.nbutton.Visible = false;
            this.nbutton.Click += new System.EventHandler(this.nbutton_Click);
            // 
            // abutton
            // 
            this.abutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.abutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.abutton.Location = new System.Drawing.Point(87, 551);
            this.abutton.Name = "abutton";
            this.abutton.Size = new System.Drawing.Size(190, 64);
            this.abutton.TabIndex = 5;
            this.abutton.Text = "AGREE";
            this.abutton.UseVisualStyleBackColor = true;
            this.abutton.Visible = false;
            this.abutton.Click += new System.EventHandler(this.abutton_Click);
            // 
            // sabutton
            // 
            this.sabutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.sabutton.Location = new System.Drawing.Point(126, 645);
            this.sabutton.Name = "sabutton";
            this.sabutton.Size = new System.Drawing.Size(152, 49);
            this.sabutton.TabIndex = 6;
            this.sabutton.Text = "STRONGLY AGREE";
            this.sabutton.UseVisualStyleBackColor = true;
            this.sabutton.Visible = false;
            this.sabutton.Click += new System.EventHandler(this.sabutton_Click);
            // 
            // nbar
            // 
            this.nbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nbar.Location = new System.Drawing.Point(407, 446);
            this.nbar.Name = "nbar";
            this.nbar.Size = new System.Drawing.Size(566, 46);
            this.nbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.nbar.TabIndex = 7;
            // 
            // dbar
            // 
            this.dbar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dbar.Location = new System.Drawing.Point(407, 340);
            this.dbar.Name = "dbar";
            this.dbar.Size = new System.Drawing.Size(566, 46);
            this.dbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.dbar.TabIndex = 8;
            // 
            // abar
            // 
            this.abar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.abar.Location = new System.Drawing.Point(407, 551);
            this.abar.Name = "abar";
            this.abar.Size = new System.Drawing.Size(566, 46);
            this.abar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.abar.TabIndex = 9;
            // 
            // sabar
            // 
            this.sabar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sabar.Location = new System.Drawing.Point(407, 649);
            this.sabar.Name = "sabar";
            this.sabar.Size = new System.Drawing.Size(566, 46);
            this.sabar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.sabar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(37, 944);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of contributers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sdlabel
            // 
            this.sdlabel.AutoSize = true;
            this.sdlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdlabel.Location = new System.Drawing.Point(1042, 257);
            this.sdlabel.Name = "sdlabel";
            this.sdlabel.Size = new System.Drawing.Size(0, 13);
            this.sdlabel.TabIndex = 12;
            // 
            // dlabel
            // 
            this.dlabel.AutoSize = true;
            this.dlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlabel.Location = new System.Drawing.Point(1042, 362);
            this.dlabel.Name = "dlabel";
            this.dlabel.Size = new System.Drawing.Size(0, 13);
            this.dlabel.TabIndex = 13;
            // 
            // nlabel
            // 
            this.nlabel.AutoSize = true;
            this.nlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nlabel.Location = new System.Drawing.Point(1042, 458);
            this.nlabel.Name = "nlabel";
            this.nlabel.Size = new System.Drawing.Size(0, 13);
            this.nlabel.TabIndex = 14;
            // 
            // alabel
            // 
            this.alabel.AutoSize = true;
            this.alabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alabel.Location = new System.Drawing.Point(1042, 571);
            this.alabel.Name = "alabel";
            this.alabel.Size = new System.Drawing.Size(0, 13);
            this.alabel.TabIndex = 15;
            // 
            // salabel
            // 
            this.salabel.AutoSize = true;
            this.salabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salabel.Location = new System.Drawing.Point(1042, 669);
            this.salabel.Name = "salabel";
            this.salabel.Size = new System.Drawing.Size(0, 13);
            this.salabel.TabIndex = 16;
            // 
            // tlabel
            // 
            this.tlabel.AutoSize = true;
            this.tlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlabel.Location = new System.Drawing.Point(310, 951);
            this.tlabel.Name = "tlabel";
            this.tlabel.Size = new System.Drawing.Size(0, 18);
            this.tlabel.TabIndex = 17;
            // 
            // adminbutton
            // 
            this.adminbutton.Location = new System.Drawing.Point(1179, 672);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(75, 23);
            this.adminbutton.TabIndex = 18;
            this.adminbutton.Text = "Admin";
            this.adminbutton.UseVisualStyleBackColor = true;
            this.adminbutton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(1015, 711);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "sWall_survey V 1.0 All Rights Reserved sWall Team ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1079, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(87, 325);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(257, 50);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(87, 433);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(257, 59);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(87, 533);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(257, 64);
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(87, 644);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(257, 50);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 733);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.tlabel);
            this.Controls.Add(this.salabel);
            this.Controls.Add(this.alabel);
            this.Controls.Add(this.nlabel);
            this.Controls.Add(this.dlabel);
            this.Controls.Add(this.sdlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sabar);
            this.Controls.Add(this.abar);
            this.Controls.Add(this.dbar);
            this.Controls.Add(this.nbar);
            this.Controls.Add(this.sabutton);
            this.Controls.Add(this.abutton);
            this.Controls.Add(this.nbutton);
            this.Controls.Add(this.sdbar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbutton);
            this.Controls.Add(this.sdbutton);
            this.Name = "Form1";
            this.Text = "sWall_Survay_v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button sdbutton;
        private System.Windows.Forms.Button dbutton;
        private System.Windows.Forms.ProgressBar sdbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button nbutton;
        private System.Windows.Forms.Button abutton;
        private System.Windows.Forms.Button sabutton;
        private System.Windows.Forms.ProgressBar nbar;
        private System.Windows.Forms.ProgressBar dbar;
        private System.Windows.Forms.ProgressBar abar;
        private System.Windows.Forms.ProgressBar sabar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sdlabel;
        private System.Windows.Forms.Label dlabel;
        private System.Windows.Forms.Label nlabel;
        private System.Windows.Forms.Label alabel;
        private System.Windows.Forms.Label salabel;
        private System.Windows.Forms.Label tlabel;
        private System.Windows.Forms.Button adminbutton;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

