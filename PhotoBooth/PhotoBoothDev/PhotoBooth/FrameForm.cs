using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhotoBooth
{
    public partial class FrameForm : Form
    {


        private Bitmap takenPicture;
        private FormSelectorController FSC;
        private PictureBox DisplayBox;
        private PictureBox pcbxLeft;
        private PictureBox pcbxRight;
        private Button btnSendEmail;
        private Label label2;
        private Button btnExitPhotoBooth2;
        private Button btnSaveToGallery;
        
        //FrameForm object needs the captured image. =null by default for testing resizing/etc. without a photo.
        public FrameForm(Bitmap takenPicture = null) 
        {
            this.takenPicture = takenPicture;
            InitializeComponent();
            this.takenPicture = takenPicture;
            
            this.FSC = new FormSelectorController(this.takenPicture);
            DisplayBox.Image = takenPicture;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }
                        
        // Next frame in List.
        private void pcbxRight_Click(object sender, EventArgs e)
        {
            this.DisplayBox.Image = this.FSC.getNextFrame();
        }


        private void InitializeComponent()
        {
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnSaveToGallery = new System.Windows.Forms.Button();
            this.pcbxRight = new System.Windows.Forms.PictureBox();
            this.pcbxLeft = new System.Windows.Forms.PictureBox();
            this.DisplayBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExitPhotoBooth2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSendEmail.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSendEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSendEmail.FlatAppearance.BorderSize = 2;
            this.btnSendEmail.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSendEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.LightCoral;
            this.btnSendEmail.Location = new System.Drawing.Point(210, 871);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(160, 75);
            this.btnSendEmail.TabIndex = 7;
            this.btnSendEmail.Text = "Email Photo";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnSaveToGallery
            // 
            this.btnSaveToGallery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveToGallery.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSaveToGallery.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSaveToGallery.FlatAppearance.BorderSize = 2;
            this.btnSaveToGallery.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveToGallery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSaveToGallery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveToGallery.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveToGallery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToGallery.ForeColor = System.Drawing.Color.LightCoral;
            this.btnSaveToGallery.Location = new System.Drawing.Point(412, 871);
            this.btnSaveToGallery.Name = "btnSaveToGallery";
            this.btnSaveToGallery.Size = new System.Drawing.Size(160, 75);
            this.btnSaveToGallery.TabIndex = 8;
            this.btnSaveToGallery.Text = "Save To Gallery";
            this.btnSaveToGallery.UseVisualStyleBackColor = false;
            this.btnSaveToGallery.Click += new System.EventHandler(this.btnSaveToGallery_Click);
            // 
            // pcbxRight
            // 
            this.pcbxRight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pcbxRight.Image = global::PhotoBooth.Properties.Resources.rightarrow;
            this.pcbxRight.InitialImage = global::PhotoBooth.Properties.Resources.rightarrow;
            this.pcbxRight.Location = new System.Drawing.Point(898, 303);
            this.pcbxRight.Name = "pcbxRight";
            this.pcbxRight.Size = new System.Drawing.Size(330, 234);
            this.pcbxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxRight.TabIndex = 2;
            this.pcbxRight.TabStop = false;
            this.pcbxRight.Click += new System.EventHandler(this.pcbxRight_Click);
            // 
            // pcbxLeft
            // 
            this.pcbxLeft.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pcbxLeft.Image = global::PhotoBooth.Properties.Resources.leftarrow;
            this.pcbxLeft.InitialImage = global::PhotoBooth.Properties.Resources.leftarrow;
            this.pcbxLeft.Location = new System.Drawing.Point(-271, 303);
            this.pcbxLeft.Name = "pcbxLeft";
            this.pcbxLeft.Size = new System.Drawing.Size(330, 234);
            this.pcbxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxLeft.TabIndex = 1;
            this.pcbxLeft.TabStop = false;
            this.pcbxLeft.Click += new System.EventHandler(this.pcbxLeft_Click_1);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DisplayBox.BackColor = System.Drawing.Color.CadetBlue;
            this.DisplayBox.InitialImage = null;
            this.DisplayBox.Location = new System.Drawing.Point(92, 107);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(800, 655);
            this.DisplayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(241, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 72);
            this.label2.TabIndex = 11;
            this.label2.Text = "Photo  Booth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitPhotoBooth2
            // 
            this.btnExitPhotoBooth2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExitPhotoBooth2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExitPhotoBooth2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExitPhotoBooth2.FlatAppearance.BorderSize = 2;
            this.btnExitPhotoBooth2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExitPhotoBooth2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitPhotoBooth2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitPhotoBooth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPhotoBooth2.ForeColor = System.Drawing.Color.LightCoral;
            this.btnExitPhotoBooth2.Location = new System.Drawing.Point(614, 871);
            this.btnExitPhotoBooth2.Name = "btnExitPhotoBooth2";
            this.btnExitPhotoBooth2.Size = new System.Drawing.Size(160, 75);
            this.btnExitPhotoBooth2.TabIndex = 14;
            this.btnExitPhotoBooth2.Text = "Exit PhotoBooth";
            this.btnExitPhotoBooth2.UseVisualStyleBackColor = false;
            this.btnExitPhotoBooth2.Click += new System.EventHandler(this.btnExitPhotoBooth2_Click);
            // 
            // FrameForm
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(984, 962);
            this.Controls.Add(this.btnExitPhotoBooth2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveToGallery);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.pcbxRight);
            this.Controls.Add(this.pcbxLeft);
            this.Controls.Add(this.DisplayBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrameForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnExitPhotoBooth2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Previous frame in List.
        private void pcbxLeft_Click_1(object sender, EventArgs e)
        {
            this.DisplayBox.Image = this.FSC.getPreviousFrame();
        }

        // Create an Emailer object and send the email.
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (takenPicture != null)
                {

                    string promptValue = Prompt.ShowDialog("Email Address: ", "Enter Email Address");
                    
                    if (promptValue != string.Empty)
                    {
                        Cursor = Cursors.WaitCursor;
                        Emailer emailer = new Emailer(promptValue, DisplayBox.Image);
                        emailer.SendEmail();
                        MessageBox.Show("Your photo has been emailed!", "Success");
                        Cursor = Cursors.Arrow;

                    }
                }
                else
                {
                    MessageBox.Show("You must take a photo to send an email.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error sending the email.\nError: " + ex.Message, "Error");
            }
            
                    
        }

        //Saves current framed photo to C:\Gallery.
        private void btnSaveToGallery_Click(object sender, EventArgs e)
        {
            try
            {
                if (takenPicture != null)
                {
                    string fileNameRandomizer;
                    string fileName;

                    // Use a randomizer to generate unique filenames. - "PhotoBoothImage" followed by formatted current datetime.
                    fileNameRandomizer = DateTime.Now.ToString();
                    fileName = fileNameRandomizer + ".jpg";
                    fileName = fileName.Replace("/", string.Empty);
                    fileName = fileName.Replace(" ", string.Empty);
                    fileName = fileName.Replace(":", string.Empty);
                    fileName = "C:\\Gallery\\PhotoBoothImage" + fileName;


                    DisplayBox.Image.Save(fileName);
                    MessageBox.Show("Your photo has been added to the photo gallery!", "Success");

                }
                else
                {
                    MessageBox.Show("You must take a picture before saving.", "Fail");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to save to the gallery.\nError: " + ex.Message, "Error"); 
            }
        }

       

        
    }
}
