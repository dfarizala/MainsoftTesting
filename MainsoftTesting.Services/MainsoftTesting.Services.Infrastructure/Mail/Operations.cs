﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MainsoftTesting.Services.Domain.Entities;
using Microsoft.Extensions.Options;
using MimeKit;

namespace MainsoftTesting.Services.Infrastructure.Mail
{
    public class Operations
    {
        public interface IMailService
        {
            Task SendEmailAsync(MailObject mailRequest);
        }

        public class MailService : IMailService
        {
            private readonly MailSettings _mailSettings;
            public MailService(IOptions<MailSettings> mailSettings)
            {
                _mailSettings = mailSettings.Value;
            }

            public async Task SendEmailAsync(MailObject mailRequest)
            {
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
                email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
                email.Subject = mailRequest.Subject;
                var builder = new BodyBuilder();
                builder.HtmlBody = mailRequest.Body;
                email.Body = builder.ToMessageBody();
                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);
            }
        }

    }
}
