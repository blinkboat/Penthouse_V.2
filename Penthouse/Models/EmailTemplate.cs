using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
namespace Penthouse.Models
{
    public class EmailTemplate
    {
        public void MessageUs(string name, string email,string number,string prjname,string comments )
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient();
            mail.To.Add("gad_mo412@hotmail.com");
            mail.From = new MailAddress("noreply@bridgethailand.com");
            mail.Subject = "ThailandPenthouses : Customer Message US";
            mail.IsBodyHtml = true;
            mail.Body = "<p>Dear Staff,</p>" +
                        "<p>You got message from customer,Please verify</p>" +
                        "<p>Name : " + name + " </p> " +
                        "<p>Email : " + email + " </p> " +
                        "<p>Number : " + number + " </p> " +
                        "<p>Project : " + prjname + " </p> " +
                        "<p>Comments : " + comments + " </p> " +
                        "<p>Best Regards,</p> " +
                        "<p>Thailand Penthouse</p>";
            SmtpServer.Host = "172.20.5.107";
            SmtpServer.Port = 25;
            SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {

            }
        }

    }
}