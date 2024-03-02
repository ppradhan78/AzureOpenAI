using AzureOpenAI.Data.BusinessObject;
using AzureOpenAI.Data.Core;
using Microsoft.AspNetCore.Mvc;

namespace AzureOpenAI.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobFileUploadController : ControllerBase
    {
        #region Global Variable(s)
        private readonly IConfigurationSettings _configuration;
        private readonly IBlobServiceCore _blobServiceCore;
        #endregion

        public BlobFileUploadController(IBlobServiceCore blobServiceCore, IConfigurationSettings configuration)
        {
            _blobServiceCore = blobServiceCore;
            _configuration = configuration;
        }

        [HttpPost(""), DisableRequestSizeLimit]
        //public async Task<IActionResult> UploadBlobs(List<string> files)
        public async Task<IActionResult> UploadBlobs()
        {

            IFormFile file = Request.Form.Files[0];
            if (file == null)
            {
                return BadRequest();
            }
            await _blobServiceCore.UploadFileBlobAsync(file.OpenReadStream(), file.FileName);
            return Ok();
        }

    }
}
