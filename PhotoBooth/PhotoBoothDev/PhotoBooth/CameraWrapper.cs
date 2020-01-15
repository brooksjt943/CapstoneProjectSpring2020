using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder.Profiles;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace PhotoBooth
{
    public class CameraWrapper
    {
        // panel that will display the video feed.
        private Panel _displayPanel;
        // string value of the video device name - can check this in device manager.
        private string _videoSourceName;
        // API classes to manage streaming and devices.
        private LiveJob _job;
        private LiveDeviceSource _deviceSource;

       
        public CameraWrapper(Panel displayPanel, string videoSourceName)
        {// constructor requires a display panel and a video source.
            _displayPanel = displayPanel;
            _videoSourceName = videoSourceName;
        }

        public void StartFeed()
        {                       

            SetDeviceSources();

            if (_deviceSource != null)
            {// set the preview window to the display panel and activate feed.
                _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(_displayPanel, _displayPanel.Handle));                
                _job.ActivateSource(_deviceSource);

            }
            else
            {// null audio or video device.
                MessageBox.Show("Unable to locate specified video device or any audio device.");
            }

        }

        private void SetDeviceSources()
        {// locates the first video device with name = _videoSourceName and the first audio device found (required for class 
         // constructor but not used in our project)
         // creates LiveJob and adds device sources.
            EncoderDevice videoDevice = null;
            EncoderDevice audioDevice = null;
            _deviceSource = null;
            
            videoDevice = EncoderDevices.FindDevices(EncoderDeviceType.Video).FirstOrDefault(vd => vd.Name == _videoSourceName);
            audioDevice = EncoderDevices.FindDevices(EncoderDeviceType.Audio).FirstOrDefault();

            if (videoDevice != null && audioDevice != null)
            {
                _job = new LiveJob();
                _deviceSource = _job.AddDeviceSource(videoDevice, audioDevice);               
            }            
                        
        }

        public Bitmap Capture()
        {// captures contents of display panel as a bitmap. 
            Bitmap bitmap = new Bitmap(_displayPanel.Width, _displayPanel.Height);         
            Graphics g = Graphics.FromImage(bitmap);
            Rectangle rectPreviewPanel = _displayPanel.Bounds;
            Point sourcePoints = _displayPanel.PointToScreen(new Point(_displayPanel.ClientRectangle.X, _displayPanel.ClientRectangle.Y));
            g.CopyFromScreen(sourcePoints, Point.Empty, rectPreviewPanel.Size);

            return bitmap;
        }
                
    }
}
