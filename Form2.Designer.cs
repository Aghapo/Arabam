namespace Arabam {
    partial class Ana_Sayfa {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Sayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.İçeribtn = new System.Windows.Forms.Button();
            this.Dndrbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(851, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // İçeribtn
            // 
            this.İçeribtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.İçeribtn.AutoSize = true;
            this.İçeribtn.BackColor = System.Drawing.Color.Maroon;
            this.İçeribtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.İçeribtn.ForeColor = System.Drawing.Color.Snow;
            this.İçeribtn.Location = new System.Drawing.Point(704, 34);
            this.İçeribtn.Name = "İçeribtn";
            this.İçeribtn.Size = new System.Drawing.Size(111, 61);
            this.İçeribtn.TabIndex = 1;
            this.İçeribtn.Text = "İçeri Gir";
            this.İçeribtn.UseVisualStyleBackColor = false;
            this.İçeribtn.Click += new System.EventHandler(this.İçeribtn_Click);
            // 
            // Dndrbtn
            // 
            this.Dndrbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dndrbtn.AutoSize = true;
            this.Dndrbtn.BackColor = System.Drawing.Color.Maroon;
            this.Dndrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dndrbtn.ForeColor = System.Drawing.Color.Snow;
            this.Dndrbtn.Location = new System.Drawing.Point(37, 34);
            this.Dndrbtn.Name = "Dndrbtn";
            this.Dndrbtn.Size = new System.Drawing.Size(111, 61);
            this.Dndrbtn.TabIndex = 2;
            this.Dndrbtn.Text = "Döndür";
            this.Dndrbtn.UseVisualStyleBackColor = false;
            this.Dndrbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ana_Sayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Arabam.Properties.Resources.Audi_Logo_1;
            this.ClientSize = new System.Drawing.Size(851, 477);
            this.Controls.Add(this.Dndrbtn);
            this.Controls.Add(this.İçeribtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ana_Sayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ana_Sayfa_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Ana_Sayfa_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button İçeribtn;
        private System.Windows.Forms.Button Dndrbtn;
    }
}