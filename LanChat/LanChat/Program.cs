using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanChat
{
    class Program
    {
        static void Main(string[] args)
        {
            //MailMessage mail= new MailMessage("fjollefar@lort.dk","geert@tsz.dk");
            //SmtpClient client = new SmtpClient();
            //client.Port = 25;
            //client.DeliveryMethod=SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Host = "smtp.google.com";
            //mail.Subject = "Test til Karsten mail";
            //mail.Body = "Hello im a nigerian prince <3";
            //client.Send(mail);

            //SmtpClient client = new SmtpClient();
            //client.Port = 80;
            //client.Host = "smtp.gmail.com";
            //client.EnableSsl = true;
            //client.Timeout = 10000;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //client.Credentials = new System.Net.NetworkCredential

            //MailMessage mm = new MailMessage("themadsk@gmail.com", "themadsk@gmail.com", "test", "test");
            //mm.BodyEncoding = UTF8Encoding.UTF8;
            //mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            //client.Send(mm);

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            while (true)
            {
                mail.From = new MailAddress("lorte@lorte.dk");
                mail.To.Add("geert@tsz.dk");
                mail.Subject = "Hello Mail";
                mail.Body = "Hello this is the nigerian prince!";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("lortemclortesen@gmail.com", "Hejmeddig27");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
        }
    }
}
