namespace PhotoGallery
{
    partial class ImageViewer
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
            this.pbxImageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImageBox
            // 
            this.pbxImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImageBox.Location = new System.Drawing.Point(0, 0);
            this.pbxImageBox.Name = "pbxImageBox";
            this.pbxImageBox.Size = new System.Drawing.Size(536, 436);
            this.pbxImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImageBox.TabIndex = 0;
            this.pbxImageBox.TabStop = false;
            // 
            // ImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 436);
            this.Controls.Add(this.pbxImageBox);
            this.Name = "ImageViewer";
            this.Text = "Image Viewer";
            this.Load += new System.EventHandler(this.ImageViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImageBox;
    }
}