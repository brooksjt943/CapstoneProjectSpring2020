namespace PhotoBooth
{
    partial class ConfirmationForm
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
            this.pbxImagePreviewBox = new System.Windows.Forms.PictureBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnRetakePhoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagePreviewBox
            // 
            this.pbxImagePreviewBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxImagePreviewBox.Location = new System.Drawing.Point(92, 176);
            this.pbxImagePreviewBox.Name = "pbxImagePreviewBox";
            this.pbxImagePreviewBox.Size = new System.Drawing.Size(800, 600);
            this.pbxImagePreviewBox.TabIndex = 0;
            this.pbxImagePreviewBox.TabStop = false;
            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProceed.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProceed.FlatAppearance.BorderSize = 2;
            this.btnProceed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnProceed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnProceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.LightCoral;
            this.btnProceed.Location = new System.Drawing.Point(146, 777);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(160, 75);
            this.btnProceed.TabIndex = 1;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click_1);
            // 
            // btnRetakePhoto
            // 
            this.btnRetakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRetakePhoto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRetakePhoto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRetakePhoto.FlatAppearance.BorderSize = 2;
            this.btnRetakePhoto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRetakePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRetakePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRetakePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetakePhoto.ForeColor = System.Drawing.Color.LightCoral;
            this.btnRetakePhoto.Location = new System.Drawing.Point(666, 777);
            this.btnRetakePhoto.Name = "btnRetakePhoto";
            this.btnRetakePhoto.Size = new System.Drawing.Size(160, 75);
            this.btnRetakePhoto.TabIndex = 2;
            this.btnRetakePhoto.Text = "Retake Photo";
            this.btnRetakePhoto.UseVisualStyleBackColor = false;
            this.btnRetakePhoto.Click += new System.EventHandler(this.btnRetakePhoto_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(241, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 72);
            this.label2.TabIndex = 10;
            this.label2.Text = "Photo  Booth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(984, 962);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRetakePhoto);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.pbxImagePreviewBox);
            this.MaximizeBox = false;
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagePreviewBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagePreviewBox;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnRetakePhoto;
        private System.Windows.Forms.Label label2;
    }
}