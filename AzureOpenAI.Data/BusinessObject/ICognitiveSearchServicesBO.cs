using AzureOpenAI.Data.SampleModel;

namespace AzureOpenAI.Data.BusinessObject
{
    public interface ICognitiveSearchServicesBO
    {
        Task<List<CognitiveSearchModel>> Search(string search);
    }
}
