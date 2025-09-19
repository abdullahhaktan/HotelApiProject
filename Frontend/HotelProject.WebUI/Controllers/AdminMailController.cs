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
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress(model.ReceiverMail, "abdullahhaktan9@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("",model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("abdullahhaktan9@gmail.com", "svwe basg phwv hans");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
