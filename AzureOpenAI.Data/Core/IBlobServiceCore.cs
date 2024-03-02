namespace AzureOpenAI.Data.Core
{
    public interface IBlobServiceCore
    {
        Task<Uri> UploadFileBlobAsync( Stream content, string fileName);
    }
}
