
namespace AzureOpenAI.Data.BusinessObject
{
    public interface IBlobServiceBO
    {
        Task<Uri> UploadFileBlobAsync(Stream content,  string fileName);
    }
}