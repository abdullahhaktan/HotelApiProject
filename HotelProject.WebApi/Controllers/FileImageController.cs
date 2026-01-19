using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        // Model class for file upload requests
        public class FileUpload
        {
            public IFormFile File { get; set; }
        }

        // POST endpoint for uploading image files
        [HttpPost]
        [Consumes("multipart/form-data")] // Specify expected content type
        public async Task<IActionResult> UploadImage([FromForm] FileUpload fileUpload)
        {
            // Generate unique filename using GUID to prevent collisions
            var fileName = Guid.NewGuid() + Path.GetExtension(fileUpload.File.FileName);

            // Combine current directory with images folder and generated filename
            var path = Path.Combine(Directory.GetCurrentDirectory(), "images/" + fileName);

            // Create file stream and save uploaded file
            var stream = new FileStream(path, FileMode.Create);
            await fileUpload.File.CopyToAsync(stream);

            // Return 201 Created response with the uploaded file info
            return Created("", fileUpload);
        }
    }
}