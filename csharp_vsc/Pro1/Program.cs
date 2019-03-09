using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello...");
            Console.ReadKey();
            Console.WriteLine("..Fuckers!");
            
            string contact = "toalgriffin@gmail.com";

            SendEmail(contact);
        }

        private static void SendEmail(string contact)
        {
            try
            {

            SmtpClient mySmtpClient = new SmtpClient("my.smtp.exampleserver.net");

            // set smtp-client with basicAuthentication
            mySmtpClient.UseDefaultCredentials = false;
            System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential("username", "password");
            mySmtpClient.Credentials = basicAuthenticationInfo;

            // add from,to mailaddresses
            MailAddress from = new MailAddress("test@example.com", "TestFromName");
            MailAddress to = new MailAddress("test2@example.com", "TestToName");
            MailMessage myMail = new System.Net.Mail.MailMessage(from, to);

            // add ReplyTo
            MailAddress rspContact = new MailAddress(contact);
            
            myMail.ReplyToList.Add(rspContact);

            // set subject and encoding
            myMail.Subject = "Test message";
            myMail.SubjectEncoding = System.Text.Encoding.UTF8;

            // set body-message and encoding
            myMail.Body = "<b>Test Mail</b><br>using <b>HTML</b>.";
            myMail.BodyEncoding = System.Text.Encoding.UTF8;
            // text or html
            myMail.IsBodyHtml = true;

            mySmtpClient.Send(myMail);
            }

            catch (SmtpException ex)
            {
            throw new ApplicationException ("SmtpException has occured: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

