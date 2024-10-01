namespace FurniFusion_E_Commerce_
{
    public interface IEmailService
    {
        Task SendEmailAsync(string email, string subject, string message);

        Task<string> GetEmailTemplate(string templateName);
        
    }
}
