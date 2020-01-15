using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoBooth
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PhotoBoothMainForm displayForm = new PhotoBoothMainForm();

            // Change the name of the video device here.
            CameraWrapper camController = new CameraWrapper(displayForm.panel1, "HD USB Camera");
            displayForm.CamWrapper = camController;
            camController.StartFeed();
            displayForm.ShowDialog();
         }
    }
}
