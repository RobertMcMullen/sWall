namespace WindowsFormsApplication2
{
    partial class Theme
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
            this.orangebutt = new System.Windows.Forms.Button();
            this.bluebutt = new System.Windows.Forms.Button();
            this.pinkbutt = new System.Windows.Forms.Button();
            this.redbutt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orangebutt
            // 
            this.orangebutt.Location = new System.Drawing.Point(12, 28);
            this.orangebutt.Name = "orangebutt";
            this.orangebutt.Size = new System.Drawing.Size(139, 91);
            this.orangebutt.TabIndex = 0;
            this.orangebutt.Text = "Red";
            this.orangebutt.UseVisualStyleBackColor = true;
            this.orangebutt.Click += new System.EventHandler(this.greenbutt_Click);
            // 
            // bluebutt
            // 
            this.bluebutt.Location = new System.Drawing.Point(182, 28);
            this.bluebutt.Name = "bluebutt";
            this.bluebutt.Size = new System.Drawing.Size(139, 91);
            this.bluebutt.TabIndex = 1;
            this.bluebutt.Text = "Blue";
            this.bluebutt.UseVisualStyleBackColor = true;
            this.bluebutt.Click += new System.EventHandler(this.bluebutt_Click);
            // 
            // pinkbutt
            // 
            this.pinkbutt.Location = new System.Drawing.Point(12, 136);
            this.pinkbutt.Name = "pinkbutt";
            this.pinkbutt.Size = new System.Drawing.Size(139, 91);
            this.pinkbutt.TabIndex = 2;
            this.pinkbutt.Text = "Pink";
            this.pinkbutt.UseVisualStyleBackColor = true;
            this.pinkbutt.Click += new System.EventHandler(this.pinkbutt_Click);
            // 
            // redbutt
            // 
            this.redbutt.Location = new System.Drawing.Point(182, 136);
            this.redbutt.Name = "redbutt";
            this.redbutt.Size = new System.Drawing.Size(139, 91);
            this.redbutt.TabIndex = 3;
            this.redbutt.Text = "Green";
            this.redbutt.UseVisualStyleBackColor = true;
            this.redbutt.Click += new System.EventHandler(this.redbutt_Click);
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 275);
            this.Controls.Add(this.redbutt);
            this.Controls.Add(this.pinkbutt);
            this.Controls.Add(this.bluebutt);
            this.Controls.Add(this.orangebutt);
            this.Name = "Theme";
            this.Text = "Theme";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button orangebutt;
        private System.Windows.Forms.Button bluebutt;
        private System.Windows.Forms.Button pinkbutt;
        private System.Windows.Forms.Button redbutt;
    }
}