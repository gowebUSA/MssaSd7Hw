using System;
using System.Collections.Generic;
using System.Text;

namespace SendEmailNotifications
{
    public class SmtpConfig : ISmtpConfig
    {
        public string SmtpServer { get; set; }

        public int SmtpPort { get; set; }

        public string SmtpUserName { get; set; }
        public string SmtpPassword { get; set; }
    }
}
