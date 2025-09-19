using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FileImageController : ControllerBase
    {
        public class FileUpload
        {
            public IFormFile File { get; set; }
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadImage([FromForm] FileUpload fileUpload)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(fileUpload.File.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "images/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await fileUpload.File.CopyToAsync(stream);
            return Created("", fileUpload);
        }
    }
}