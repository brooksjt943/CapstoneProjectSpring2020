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
{// this object holds the enlarged image when the user clicks on the thumbnail.
    public partial class ImageViewer : Form
    {
        private Image _img;
        public ImageViewer(Image img)
        {
            InitializeComponent();
            this._img = img;
            this.pbxImageBox.Image = img;         
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {
            
        }
    }
}
