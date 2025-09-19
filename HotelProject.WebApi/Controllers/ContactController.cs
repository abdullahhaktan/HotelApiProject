using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contacService)
        {
            _contactService = contacService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date=Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            _contactService.TInsert(contact);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            var value = _contactService.TGetContactCount();
            return Ok(value);
        }
        [HttpGet("GetSendMessageCount")]
        public IActionResult GetSendMessageCount()
        {
            var value = _contactService.TSendMessageCount();
            return Ok(value);
        }
        [HttpGet("ChangeMessageId/{id}")]
        public IActionResult ChangeIsRead(int id)
        {
            var value = _contactService.TGetById(id);
            value.isRead = true;
            _contactService.TUpdate(value);
            return Ok();
        }
    }
}
