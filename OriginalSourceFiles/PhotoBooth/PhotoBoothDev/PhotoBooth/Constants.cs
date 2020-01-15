using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PhotoBooth
{
    class Constants
    {

        public List<Frame> FrameList = new List<Frame>();

        // Add new frames here.  ("Frame Name", Width, Height, X, Y position (top left corner point)
        public Constants() {
            
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\DotsFrame.png"), 800, 598, 0, 0)); 
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\DotsFrameLogo.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\FlowerFrame.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\FlowerFrameColor.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\FlowerFrameColor2.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\PaintFrame.png"), 736, 572, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\PaintFrameLogo.png"), 736, 572, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\PaintFrameLogo2.png"), 736, 572, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\PaintFrameLogo3.png"), 736, 572, 0, 0));

            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\PolkaDots.png"), 697, 700, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\Rainbow.png"), 750, 550, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RedFlowerFrame.png"), 500, 500, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RedFrame.png"), 800, 577, 0, 0));

            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RedFrameLogo.png"), 800, 577, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RedFrameLogo2.png"), 800, 577, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RedFrameLogo3.png"), 800, 577, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RoseFrame.png"), 641, 531, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RoseFrameLogo.png"), 641, 531, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\RoseFrameLogo2.png"), 641, 531, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\TestFrame.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\TestFrameColor.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("C:\\Frames\\Water.png"), 620, 440, 0, 0));

                }
        
    }
}
