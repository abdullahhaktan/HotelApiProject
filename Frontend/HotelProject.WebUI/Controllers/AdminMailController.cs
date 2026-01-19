using HotelProject.WebUI.Models.Mail;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Security;
using Newtonsoft.Json.Serialization;
using MailKit.Net.Smtp;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        // GET action to display email sending form
        public IActionResult Index()
        {
            return View();
        }

        // POST action to handle email sending
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            // Create MIME message for email
            MimeMessage mimeMessage = new MimeMessage();

            // Set sender address (using fixed sender email in From field)
            MailboxAddress mailboxAddressFrom = new MailboxAddress(model.ReceiverMail, "abdullahhaktan9@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            // Set recipient address (using email from form in To field)
            MailboxAddress mailboxAddressTo = new MailboxAddress("", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            // Build email body
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body; // Plain text body
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            // Set email subject
            mimeMessage.Subject = model.Subject;

            // Configure and send email via SMTP
            SmtpClient client = new SmtpClient();

            // Connect to Gmail SMTP server
            client.Connect("smtp.gmail.com", 587, false);

            // Authenticate with sender credentials (Note: Hardcoded credentials - security issue)
            client.Authenticate("abdullahhaktan9@gmail.com", "svwe basg phwv hans");

            // Send the email
            client.Send(mimeMessage);

            // Disconnect from SMTP server
            client.Disconnect(true);

            return View();
        }
    }
}