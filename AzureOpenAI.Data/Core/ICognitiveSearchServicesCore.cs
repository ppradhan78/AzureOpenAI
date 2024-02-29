using AzureOpenAI.Data.SampleModel;

namespace AzureOpenAI.Data.Core
{
    public interface ICognitiveSearchServicesCore
    {
        Task<List< CognitiveSearchModel>> Search(string search);
    }
}
