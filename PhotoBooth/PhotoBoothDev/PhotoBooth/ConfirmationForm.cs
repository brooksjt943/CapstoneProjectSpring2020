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
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private Bitmap _imageToPreview;
        public ConfirmationForm(Bitmap imageToPreview)
        {// set the picture box's image source to the image passed from Photo Booth Main Form.
            InitializeComponent();
            _imageToPreview = imageToPreview;
            pbxImagePreviewBox.Image = _imageToPreview;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }



        private void btnProceed_Click_1(object sender, EventArgs e)
        {
            FrameForm FrameForm = new FrameForm(_imageToPreview);
            FrameForm.Show();
            this.Close();
            this.Dispose();
        }

        private void btnRetakePhoto_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }


    }
