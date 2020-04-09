using System;
using System.Collections.Generic;
using System.Text;

namespace SendEmailNotifications
{
    public interface ISmtpConfig
    {
        string SmtpServer { get; }
        int SmtpPort { get; }
        string SmtpUserName { get; set; }
        string SmtpPassword { get; set; }
    }
}
