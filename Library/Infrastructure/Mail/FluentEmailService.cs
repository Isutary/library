using Library.Models.Mail;
using System.Threading.Tasks;
using E = FluentEmail.Core.Email;

namespace Library.Infrastructure.Mail
{
    public class FluentEmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;
        
        public FluentEmailService(EmailSettings emailSettings) => (_emailSettings) = (emailSettings);

        public Task SendEmailAsync(EmailMessage message)
        {
            return E.From(_emailSettings.Sender, _emailSettings.SenderName)
                .To(message.To)
                .Subject(message.Subject)
                .Body(message.Content, true)
                .SendAsync();
        }
    }
}
