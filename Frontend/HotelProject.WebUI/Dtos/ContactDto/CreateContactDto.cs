using Newtonsoft.Json;

namespace HotelProject.WebUI.Dtos.ContactDto
{
    public class CreateContactDto
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool isRead { get; set; }
        public DateTime Date { get; set; }
        public int MessageCategoryID { get; set; }

    }
}
