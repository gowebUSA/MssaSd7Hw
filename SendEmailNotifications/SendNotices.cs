using System;
using MimeKit;
using MailKit.Net.Smtp;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace SendEmailNotifications
{

    class SendNotices
    {
        static SmtpConfig _smtp;
        static List<EmailAddress> _subscribers;

        static void Configure()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                //.AddUserSecrets<SendNotices>()
                //.AddEnvironmentVariables()
                ;
            IConfigurationRoot configuration = builder.Build();

            var smtp = new SmtpConfig();
            configuration.GetSection("Email").Bind(smtp);

            //smtp.SmtpServer = "smtp.ipage.com";
            //smtp.SmtpPort = 465;
            //smtp.SmtpUserName = "richard.go.mssa@gowebdesign.us";
            //smtp.SmtpPassword = "nuPa$$w0rd";

            _smtp = smtp;
            _subscribers = configuration.GetSection("Subscribers").Get<List<EmailAddress>>();
        }

        static MimeMessage BuildMessage()
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("NoReply", _smtp.SmtpUserName));
            message.To.AddRange(_subscribers.Select(to => new MailboxAddress(to.Name, to.Address)));
            //message.To.Add(new MailboxAddress("Richard", "richard.go.mssa@gmail.com"));
            message.Subject = "test email";
            message.Body = new TextPart("plain")
            {
                Text = $"Hello. Test email. It is {DateTime.Now.ToShortTimeString()}."
            };
            return message;
        }
        static void Send()
        {
            Configure();

            try
            {
                using (var client = new SmtpClient())
                {
                    client.Connect(_smtp.SmtpServer, _smtp.SmtpPort, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_smtp.SmtpUserName, _smtp.SmtpPassword);
                    client.Send(BuildMessage());
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
