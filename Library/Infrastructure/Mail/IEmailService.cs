using Library.Models.Mail;
using System.Threading.Tasks;

namespace Library.Infrastructure.Mail
{
    public interface IEmailService
    {
        Task SendEmailAsync(EmailMessage message);
    }
}
