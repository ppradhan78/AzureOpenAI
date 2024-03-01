using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureOpenAI.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobFileUploadController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> UploadBlobs(List<IFormFile> files)
        {
            return Ok();
        }
    }
}
