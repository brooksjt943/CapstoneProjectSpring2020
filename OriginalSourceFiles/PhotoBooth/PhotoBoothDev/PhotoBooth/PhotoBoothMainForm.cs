using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PhotoBooth
{
    public partial class PhotoBoothMainForm : Form
    {// timer object and counter for the timer.
        private System.Windows.Forms.Timer _timer1;
        private Label lblCountDown;
        private Label label1;
        private Button btnTakePhoto;
        public Panel panel1;
        private Button btnExitPhotoBooth;
        private Label label2;
        private int _counter = 3;

        public PhotoBoothMainForm()
        {
            InitializeComponent();
            lblCountDown.Text = "3...";
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        //PhotoBoothMainForm object needs a CameraWrapper
        public CameraWrapper CamWrapper { get; set; }

        private void btnTakePhoto_Click(object sender, EventArgs e)
        {// start countdown to photo capture when Take Photo is clicked.    
            StartCountdown();
        }

        public void StartCountdown()
        {// do the countdown, check counter value with _timer1_Tick event on each tick.
            _counter = 3;
            _timer1 = new System.Windows.Forms.Timer();
            _timer1.Tick += new EventHandler(_timer1_Tick);
            _timer1.Interval = 1000; // 1 second
            _timer1.Start();
            lblCountDown.Text = _counter.ToString() + "...";
        }

        //Timer to provide the countdown functionality before a photo is taken.
        private void _timer1_Tick(object sender, EventArgs e)
        {// checks counter value on each tick, takes photo when _counter = 0.
            _counter--;
            if (_counter == 0)
            {
                _timer1.Stop();
                lblCountDown.Text = "OK!";
                // create a Bitmap from the video feed capture.
                Bitmap image = CamWrapper.Capture();
                // open the confirmation form and pass it the image.
                ConfirmationForm confirmationForm = new ConfirmationForm(image);
                confirmationForm.Show();
                

            }
            else
            {
                lblCountDown.Text = _counter.ToString() + "...";
            }
        }

        private void InitializeComponent()
        {
            this.lblCountDown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitPhotoBooth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCountDown
            // 
            this.lblCountDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCountDown.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblCountDown.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCountDown.Location = new System.Drawing.Point(412, 758);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(160, 75);
            this.lblCountDown.TabIndex = 7;
            this.lblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(395, 734);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Photo Countdown";
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTakePhoto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTakePhoto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTakePhoto.FlatAppearance.BorderSize = 2;
            this.btnTakePhoto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTakePhoto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTakePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTakePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakePhoto.ForeColor = System.Drawing.Color.LightCoral;
            this.btnTakePhoto.Location = new System.Drawing.Point(164, 758);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(160, 75);
            this.btnTakePhoto.TabIndex = 5;
            this.btnTakePhoto.Text = "Take Photo!";
            this.btnTakePhoto.UseVisualStyleBackColor = false;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Location = new System.Drawing.Point(92, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnExitPhotoBooth
            // 
            this.btnExitPhotoBooth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnExitPhotoBooth.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExitPhotoBooth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExitPhotoBooth.FlatAppearance.BorderSize = 2;
            this.btnExitPhotoBooth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExitPhotoBooth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExitPhotoBooth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitPhotoBooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitPhotoBooth.ForeColor = System.Drawing.Color.LightCoral;
            this.btnExitPhotoBooth.Location = new System.Drawing.Point(660, 758);
            this.btnExitPhotoBooth.Name = "btnExitPhotoBooth";
            this.btnExitPhotoBooth.Size = new System.Drawing.Size(160, 75);
            this.btnExitPhotoBooth.TabIndex = 8;
            this.btnExitPhotoBooth.Text = "Exit Photo Booth";
            this.btnExitPhotoBooth.UseVisualStyleBackColor = false;
            this.btnExitPhotoBooth.Click += new System.EventHandler(this.btnExitPhotoBooth_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(241, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 72);
            this.label2.TabIndex = 9;
            this.label2.Text = "Photo  Booth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhotoBoothMainForm
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(984, 962);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExitPhotoBooth);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTakePhoto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PhotoBoothMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnTakePhoto_Click_1(object sender, EventArgs e)
        {
            StartCountdown();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExitPhotoBooth_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
