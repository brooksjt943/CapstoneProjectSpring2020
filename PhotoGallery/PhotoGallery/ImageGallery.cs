using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PhotoGallery
{
    public partial class ImageGallery : UserControl
    {// The user control holds all of the picture boxes that get dynamically drawn on load.
        public ImageGallery()
        {
            InitializeComponent();
        }
        int CtrlWidth;
        int CtrlHeight;
        int PicWidth;
        int PicHeight;
        int XLocation;
        int YLocation;
        
       
        private void ImageGallery_Resize(System.Object sender, System.EventArgs e)
        {
            CtrlHeight = this.Height;
            CtrlWidth = this.Width;
        }
        // Location that the PhotoBooth saves images. C:\Gallery
        private string _Directory_Path;
        public string Directorypath
        {
            get { return _Directory_Path; }
            set
            {
                _Directory_Path = value;
                XLocation = 25;
                YLocation = 25;
                PicWidth = 117;
                PicHeight = 109;
                CreateGallery();
            }
        }
        int i = 0;
        private void DrawPictureBox(string _filename, string _displayname)
        {
            CtrlHeight = this.Height;
            CtrlWidth = this.Width;

            PictureBox Pic1 = new PictureBox();
            Pic1.Location = new System.Drawing.Point(XLocation, YLocation);
            XLocation = XLocation + PicWidth + 20;
            if (XLocation + PicWidth >= CtrlWidth)
            {
                XLocation = 25;
                YLocation = YLocation + PicHeight + 20;
            }
            Pic1.Name = "PictureBox" + i;
            i += 1;
            Pic1.Size = new System.Drawing.Size(PicWidth, PicHeight);
            Pic1.TabIndex = 0;
            Pic1.TabStop = false;
            Pic1.BorderStyle = BorderStyle.Fixed3D;
            //this.toolTip1.SetToolTip(Pic1, _displayname);
            Pic1.MouseEnter += Pic1_MouseEnter;
            Pic1.MouseLeave += Pic1_MouseLeave;
            Pic1.Click += ShowPhoto;
            this.Controls.Add(Pic1);
            Pic1.Image = Image.FromFile(_filename);
            Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            
        }

       private void ShowPhoto(System.Object sender, System.EventArgs e)
        {//sender is the photo that was clicked.  This shows an enlarged version.
            PictureBox pbx = (PictureBox)sender;
            Image img = pbx.Image;
            ImageViewer viewer = new ImageViewer(img);
            viewer.ShowDialog();
        }
        private void CreateGallery()
        { // Generate the small picture boxes inside the user control (ImageGallery)
            i = 0;
            RemoveControls();
            if (Directorypath != null)
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Directorypath);

                System.IO.FileInfo[] diar1 = di.GetFiles("*.jpg");
                System.IO.FileInfo[] diar2 = di.GetFiles("*.bmp");
                System.IO.FileInfo[] diar3 = di.GetFiles("*.png");
                System.IO.FileInfo[] diar4 = di.GetFiles("*.gif");

                var diarList = new List<System.IO.FileInfo>();
                diarList.AddRange(diar1);
                diarList.AddRange(diar2);
                diarList.AddRange(diar3);
                diarList.AddRange(diar4);
                System.IO.FileInfo[] diar = diarList.ToArray();

                System.IO.FileInfo dra = null;
                foreach (System.IO.FileInfo dra_loopVariable in diar1)
                {
                    dra = dra_loopVariable;
                    DrawPictureBox(dra.FullName, dra.Name);
                }
            }
        }

        private void Pic1_MouseEnter(System.Object sender, System.EventArgs e)
        {// Highlights the thumbnail that the mouse is over.
            PictureBox Pic = default(PictureBox);
            Pic = (PictureBox)sender;
            Pic.BorderStyle = BorderStyle.FixedSingle;
            
        }
        private void Pic1_MouseLeave(System.Object sender, System.EventArgs e)
        {
            PictureBox Pic = default(PictureBox);
            Pic = (PictureBox)sender;
            Pic.BorderStyle = BorderStyle.Fixed3D;
            
            
            
        }
        private void RemoveControls()
        {// clear old picture boxes.
            Again:
            foreach (Control ctrl in this.Controls)
            {
                if ((ctrl) is PictureBox)
                {
                    this.Controls.Remove(ctrl);
                }
            }
            if (this.Controls.Count > 0)
            {
                goto Again;
            }
        }
    }
}
