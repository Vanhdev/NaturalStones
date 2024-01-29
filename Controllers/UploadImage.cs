using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace NaturalStones.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public partial class UploadController : Controller
    {
        private readonly IWebHostEnvironment environment;

        public UploadController(IWebHostEnvironment environment)
        {
            this.environment = environment;
        }

        [HttpPost("Blog-image")]
        public IActionResult Image(IFormFile file)
        {
            try
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetFileName(file.FileName)}{Path.GetExtension(file.FileName)}";

                if (!Directory.Exists($"{Directory.GetCurrentDirectory()}/Assets/Images"))
                {
                    Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/Assets/Images");
                }

                using (var stream = new FileStream(Path.Combine($"{Directory.GetCurrentDirectory()}/Assets/Images", fileName), FileMode.Create))
                {
                    // Save the file
                    file.CopyTo(stream);

                    // Return the URL of the file
                    var url = $"/Assets/Images/{fileName}";

                    return Ok(new { Url = url });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("Gallery-image")]
        public IActionResult GalleryImage(IFormFile file)
        {
            try
            {
                var fileName = $"{Guid.NewGuid()}{Path.GetFileName(file.FileName)}{Path.GetExtension(file.FileName)}";

                if (!Directory.Exists($"{Directory.GetCurrentDirectory()}/Assets/Gallery"))
                {
                    Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/Assets/Gallery");
                }

                using (var stream = new FileStream(Path.Combine($"{Directory.GetCurrentDirectory()}/Assets/Gallery", fileName), FileMode.Create))
                {
                    // Save the file
                    file.CopyTo(stream);

                    // Return the URL of the file
                    var url = $"/Assets/Gallery/{fileName}";

                    return Ok(new { Url = url });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("Product-image")]
        public IActionResult ProductImage(IFormFile[] files)
        {
            try
            {
                List<string> urls = new List<string>();
                foreach(var file in files)
                {
                    var fileName = $"{Guid.NewGuid()}{Path.GetFileName(file.FileName)}{Path.GetExtension(file.FileName)}";

                    if (!Directory.Exists($"{Directory.GetCurrentDirectory()}/Assets/Images"))
                    {
                        Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}/Assets/Images");
                    }

                    using (var stream = new FileStream(Path.Combine($"{Directory.GetCurrentDirectory()}/Assets/Images", fileName), FileMode.Create))
                    {
                        // Save the file
                        file.CopyTo(stream);

                        // Return the URL of the file
                        var url = $"/Assets/Images/{fileName}";
                        urls.Add(url);
                        
                    }
                }
                return Ok(new { Urls = urls });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
