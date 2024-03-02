﻿using AzureOpenAI.Data.BusinessObject;

namespace AzureOpenAI.Data.Core
{
    public class BlobServiceCore : IBlobServiceCore
    {
        #region Global Variable(s)
        private readonly IConfigurationSettings _configuration;
        public readonly IBlobServiceBO _blobService;
        #endregion

        public BlobServiceCore(IBlobServiceBO blobService, IConfigurationSettings configuration)
        {
            _blobService = blobService;
            _configuration = configuration;
        }

        public Task<Uri> UploadFileBlobAsync(Stream content, string fileName)
        {
          return  _blobService.UploadFileBlobAsync(content, fileName);
        }
    }
}
