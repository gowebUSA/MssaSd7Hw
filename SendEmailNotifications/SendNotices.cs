using System;
using MimeKit;
using MailKit.Net.Smtp;

namespace SendEmailNotifications
{

    class SendNotices
    {
        static SmtpConfig _smtp;

        static void Configure()
        {
            var smtp = new SmtpConfig();
            smtp.SmtpServer = "smtp.ipage.com";
            smtp.SmtpPort = 465;
            smtp.SmtpUserName = "richard.go.mssa@gowebdesign.us";
            smtp.SmtpPassword = "blank";

            _smtp = smtp;
        }

        static void Send()
        {
            Configure();

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("NoReply", _smtp.SmtpUserName));
            message.To.Add(new MailboxAddress("Richard", "richard.go.mssa@gmail.com"));
            message.Subject = "test email";
            message.Body = new TextPart("plain")
            {
                Text = $"Hello. It is {new DateTime().ToShortTimeString()}."
            };
            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect(_smtp.SmtpServer, _smtp.SmtpPort, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_smtp.SmtpUserName, _smtp.SmtpPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void Main(string[] args)
        {
            Send();
        }
    }
}
