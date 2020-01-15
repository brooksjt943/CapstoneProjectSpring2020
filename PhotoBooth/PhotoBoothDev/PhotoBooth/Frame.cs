using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBooth
{
    class Frame
    {

        private Bitmap bmp;
        private int innerSizeWidth;
        private int innerSizeHeight;
        private int offsetX;
        private int offsetY;


        public Frame(Bitmap bmp, int innerSizeWidth, int innerSizeHeight, int offsetX, int offsetY)
        {
            this.bmp = bmp;
            this.innerSizeWidth = innerSizeWidth;
            this.innerSizeHeight = innerSizeHeight;
            this.offsetX = offsetX;
            this.offsetY = offsetY;
        }
        public Bitmap getBMP()
        {
            return this.bmp;
        }

        public int getOffsetX()
        {
            return this.offsetX;
        }

        public int getOffsetY()
        {
            return this.offsetY;
        }

        public int getInnerSizeWidth()
        {
            return this.innerSizeWidth;
        }

        public int getInnerSizeHeight()
        {
            return this.innerSizeHeight;
        }



    }
}
