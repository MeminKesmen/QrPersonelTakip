using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public static class MailGonder
    {
        public static string Gonderen = "QrTakipProje";
        public static string mail = "mail";
        public static string sifre = "sifre";
        public static void Microsoft(string AliciMail, string Baslik, string icerik, string ek)
        {
            
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.outlook.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(MailGonder.mail, MailGonder.sifre);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(MailGonder.mail, MailGonder.Gonderen);
            mail.To.Add(AliciMail);
            mail.Subject = Baslik;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            if (ek != null)
            {
                mail.Attachments.Add(new Attachment(ek));
            }
            sc.Timeout = 100;
            sc.Send(mail);
        }
    }
}
