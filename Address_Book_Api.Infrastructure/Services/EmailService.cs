using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using Microsoft.Extensions.Configuration;
using Address_Book_Api.Application.Services;

namespace Address_Book_Api.Infrastructure.Services
{
    public class EmailService(IConfiguration configuration) : IEmailService
    {
        private readonly IConfiguration _configuration = configuration;

        public async Task<bool> SendEmailAsync(string toEmail, string subject, string message)
        {
            try
            {

           
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_configuration["EmailSettings:SenderEmail"]));
            email.To.Add(MailboxAddress.Parse(toEmail));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = message };

            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_configuration["EmailSettings:SenderEmail"],
                                            _configuration["EmailSettings:AppPassword"]);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }

            return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
