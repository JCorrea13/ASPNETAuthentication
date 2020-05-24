using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace ConfArch.Web.Areas.Identity
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // You can implement this via SendGrid.com
            throw new System.NotImplementedException();
        }
    }
}
