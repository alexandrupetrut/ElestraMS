using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Elestra.BLL
{
    public class Utility
    {
        public static bool SendEmail(string ToEmail,string Subject,string Body)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("alexandru.petrut.popa@gmail.com", "lolznope");

            MailMessage mm = new MailMessage("Admin@Elestra.com", ToEmail, Subject, Body);
                        
            //client.Send(mm);
            return true;
        }
    }
}
