using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;


namespace PhotoBooth
{
    class FormSelectorController
    {
        
        private int currentFrameNum;
        private Frame currentFrame;
        private Bitmap takenPicture;
        private Constants Constants;

        

        // Constructor accepts the image capture.
        public FormSelectorController(Bitmap takenPicture)
        {
            
            this.Constants = new Constants();
            currentFrameNum = 0;

            this.currentFrame = getFrame();
            this.takenPicture = takenPicture;

        }

        public Frame getFrame()
        {
            return this.Constants.FrameList[this.currentFrameNum];
        }

        // Right arrow - move to next frame in List
        public Bitmap getNextFrame()
        {
            if (this.currentFrameNum == this.Constants.FrameList.Count - 1)
            {
                this.currentFrameNum = 0;
            }
            else {
                this.currentFrameNum += 1;
            }
            return LayerImages(this.getFrame(), this.takenPicture);
        }

        // Left arrow - previous frame from List.
        public Bitmap getPreviousFrame()
        {
            if (this.currentFrameNum == 0)
            {
                this.currentFrameNum = this.Constants.FrameList.Count -1;
            }
            else {
                this.currentFrameNum -= 1;
            }
            return LayerImages(this.getFrame(), this.takenPicture);
        }

        //Merges with resized image.
        public Bitmap LayerImages(Frame Frame, Bitmap Picture)
        {
            
            Bitmap baseImage = Picture;
            Bitmap borderImage = Frame.getBMP();
            Bitmap finalImage = new Bitmap(borderImage.Width, borderImage.Height);
            //baseImage = FixedSize(baseImage, Frame.getInnerSizeWidth(), Frame.getInnerSizeHeight());
            Image imageToSend = Resize(baseImage, Frame.getInnerSizeWidth(), Frame.getInnerSizeWidth(), RotateFlipType.RotateNoneFlipNone);

            using (Graphics g = Graphics.FromImage(finalImage))
            {

                g.Clear(Color.Transparent);
                g.DrawImage(imageToSend, new Rectangle(Frame.getOffsetX(), Frame.getOffsetY(), Frame.getInnerSizeWidth(), Frame.getInnerSizeHeight()));
                g.DrawImage(borderImage, new Rectangle(0, 0, borderImage.Width, borderImage.Height));
                



            }

            return finalImage;
        }


        // Resize image code from Stack Overflow - RotateFlipType should always be RotateNoneFlipNone      
        public static Image Resize(Image image, int width, int height, RotateFlipType rotateFlipType)
        {
            // clone the Image instance, since we don't want to resize the original Image instance
            var rotatedImage = image.Clone() as Image;
            rotatedImage.RotateFlip(rotateFlipType);
            var newSize = CalculateResizedDimensions(rotatedImage, width, height);

            var resizedImage = new Bitmap(newSize.Width, newSize.Height, PixelFormat.Format32bppArgb);
            resizedImage.SetResolution(72, 72);

            using (var graphics = Graphics.FromImage(resizedImage))
            {
                // set parameters to create a high-quality thumbnail
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // use an image attribute in order to remove the black/gray border around image after resize
                // (most obvious on white images), see this post for more information:
                // http://www.codeproject.com/KB/GDI-plus/imgresizoutperfgdiplus.aspx
                using (var attribute = new ImageAttributes())
                {
                    attribute.SetWrapMode(WrapMode.TileFlipXY);

                    // draws the resized image to the bitmap
                    graphics.DrawImage(rotatedImage, new Rectangle(new Point(0, 0), newSize), 0, 0, rotatedImage.Width, rotatedImage.Height, GraphicsUnit.Pixel, attribute);
                }
            }

            return resizedImage;
        }

        private static Size CalculateResizedDimensions(Image image, int desiredWidth, int desiredHeight)
        {
            var widthScale = (double)desiredWidth / image.Width;
            var heightScale = (double)desiredHeight / image.Height;

            // scale to whichever ratio is smaller, this works for both scaling up and scaling down
            var scale = widthScale < heightScale ? widthScale : heightScale;

            return new Size
            {
                Width = (int)(scale * image.Width),
                Height = (int)(scale * image.Height)
            };
        }



    }
}
