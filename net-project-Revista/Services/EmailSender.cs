using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_project_Revista.Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(IOptions<EmailSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        public EmailSenderOptions Options { get; }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(Options.SENDGRID_KEY, email, subject, message);
        }

        public Task Execute(string apiKey, string email, string subject, string message)
        {
            var client = new SendGridClient(apiKey);

            //create email
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(Options.SENDGRID_EMAIL, Options.SENDGRID_NAME),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            //add recipient
            msg.AddTo(new EmailAddress(email));

            //disable click tracking
            msg.SetClickTracking(false, false);

            //send email
            return client.SendEmailAsync(msg);
        }
    }
}
