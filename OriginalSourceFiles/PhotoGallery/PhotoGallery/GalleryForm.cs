using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoGallery
{
    public partial class GalleryForm : Form
    {
        public GalleryForm()
        { // Just the form to hold the controls.
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            this.Gallery.Directorypath = "C:\\Gallery";
        }

        private void btnExitPhotoGallery_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
