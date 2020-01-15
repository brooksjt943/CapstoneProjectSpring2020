using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Drawing;

namespace PhotoBooth
{
    class Emailer
    {
        private MailAddress objFromAddress;
        private MailAddress objToAddress;
        private const string c_FromAddress = "kiosk@sandhills.edu";
        private const string c_FromName = "Sandhills Programming Department";
        
        private const string c_FromPassword = "Pa55w0rd";
        private const string c_Subject = "Your Sandhills PhotoBooth Image";
        private const string c_Body = "Enjoy your custom Sandhills souvenir photo!";
        private MailMessage _email;
        private SmtpClient _smtp;

        public Emailer(string toAddress, Image imageToEmail)
        {
            this.ToAddress = toAddress;
            this.ImageToEmail = imageToEmail;
        }

        public string ToAddress { get; set; }

        public Image ImageToEmail { get; set; }

        public void SendEmail()
        {

            if (System.IO.File.Exists("C:\\TempImages\\tmpFile.jpg"))
                System.IO.File.Delete("C:\\TempImages\\tmpFile.jpg");
            ImageToEmail.Save("C:\\TempImages\\tmpFile.jpg");

            _smtp = new SmtpClient();
            _smtp.Host =  "smtp.office365.com";
            _smtp.Port = 587;
            _smtp.EnableSsl = true;
            _smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtp.UseDefaultCredentials = false;
            _smtp.Credentials = new NetworkCredential(c_FromAddress, c_FromPassword);

            objFromAddress = new MailAddress(c_FromAddress, c_FromName);
            objToAddress = new MailAddress(this.ToAddress);
            _email = new MailMessage(objFromAddress, objToAddress);
            _email.Subject = c_Subject;
            _email.Body = c_Body;
            _email.Attachments.Add(new Attachment("C:\\TempImages\\tmpFile.jpg"));

            _smtp.Send(_email);
            _email.Dispose();
        }



    }
}