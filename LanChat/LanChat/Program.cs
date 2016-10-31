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
                
                mail.To.Add("Bonke_Andreasbonke@Hotmail.com");
                mail.To.Add("aebeloe.madsen@hotmail.com");
                mail.To.Add("Nikolajbang1995@gmail.com");
                mail.Subject = "Mock exam svar";
                mail.Body = "SNYDT";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("lortemclortesen@gmail.com", "Hejmeddig27");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
        }
    }
}
