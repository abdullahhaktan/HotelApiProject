using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static HotelProject.WebApi.Controllers.FileImageController;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessController : ControllerBase
    {
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UploadFile([FromForm] FileUpload fileUpload)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(fileUpload.File.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "files/" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await fileUpload.File.CopyToAsync(stream);
            return Created("", fileUpload);
        }
    }
}
