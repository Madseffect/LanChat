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
           

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            while (true)
            {
                mail.From = new MailAddress("lorte@lorte.dk");
                mail.To.Add("mikimoller@gmail.com");
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
