namespace PhotoGallery
{
    partial class GalleryForm
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
            this.btnExitPhotoGallery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Gallery = new PhotoGallery.ImageGallery();
            this.SuspendLayout();
            // 
            // btnExitPhotoGallery
            // 
            this.btnExitPhotoGallery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExitPhotoGallery.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExitPhotoGallery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExitPhotoGallery.FlatAppearance.BorderSize = 2;
            this.btnExitPhotoGallery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExitPhotoGallery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitPhotoGallery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitPhotoGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPhotoGallery.ForeColor = System.Drawing.Color.LightCoral;
            this.btnExitPhotoGallery.Location = new System.Drawing.Point(595, 619);
            this.btnExitPhotoGallery.Name = "btnExitPhotoGallery";
            this.btnExitPhotoGallery.Size = new System.Drawing.Size(160, 75);
            this.btnExitPhotoGallery.TabIndex = 15;
            this.btnExitPhotoGallery.Text = "Exit Photo Gallery";
            this.btnExitPhotoGallery.UseVisualStyleBackColor = false;
            this.btnExitPhotoGallery.Click += new System.EventHandler(this.btnExitPhotoGallery_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(424, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 72);
            this.label2.TabIndex = 16;
            this.label2.Text = "Photo  Gallery";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gallery
            // 
            this.Gallery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gallery.AutoScroll = true;
            this.Gallery.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Gallery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Gallery.Directorypath = null;
            this.Gallery.Location = new System.Drawing.Point(0, 0);
            this.Gallery.Name = "Gallery";
            this.Gallery.Size = new System.Drawing.Size(1350, 750);
            this.Gallery.TabIndex = 0;
            // 
            // GalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1350, 730);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitPhotoGallery);
            this.Controls.Add(this.Gallery);
            this.Name = "GalleryForm";
            this.Text = "Photo Gallery";
            this.ResumeLayout(false);

        }

        #endregion

        private ImageGallery Gallery;
        private System.Windows.Forms.Button btnExitPhotoGallery;
        private System.Windows.Forms.Label label2;
    }
}

