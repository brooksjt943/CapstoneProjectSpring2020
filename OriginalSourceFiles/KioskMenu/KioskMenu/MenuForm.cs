using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KioskMenu
{
    public partial class MenuForm : Form
    {
        const string password = "kioskPassword2017";
        public MenuForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void btnPhotoBooth_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\PhotoBooth.appref-ms";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnCellularAutomaton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\CellularAutomaton_v6.exe";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnPhotoGallery_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\PhotoGallery.appref-ms";
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnCloseMenu_Click(object sender, EventArgs e)
        {
            string promptValue = Prompt.ShowDialog("Passwprd: ", "Enter Password");

            if (promptValue == password)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }
    }
}
