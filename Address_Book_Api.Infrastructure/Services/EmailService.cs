using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Address_Book_Api.Application.Services;
using Microsoft.Extensions.Options;
using Address_Book_Api.Application.Models;

namespace Address_Book_Api.Infrastructure.Services
{
    public class EmailService(IOptions<EmailSettings> emailSettings) : IEmailService
    {
        private readonly EmailSettings _emailSettings = emailSettings.Value;

        public async Task<bool> SendEmailAsync(string toEmail, string subject, string message)
        {
            try
            {

           
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_emailSettings.SenderEmail));
            email.To.Add(MailboxAddress.Parse(toEmail));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message };

                using var smtp = new SmtpClient();
                await smtp.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.SmtpPort, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_emailSettings.SenderEmail,
                                            _emailSettings.SenderPassword);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
