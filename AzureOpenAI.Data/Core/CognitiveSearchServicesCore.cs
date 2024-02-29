using AzureOpenAI.Data.BusinessObject;
using AzureOpenAI.Data.SampleModel;

namespace AzureOpenAI.Data.Core
{
    public class CognitiveSearchServicesCore : ICognitiveSearchServicesCore
    {
        #region Global Variable(s)
        private readonly IConfigurationSettings _configuration;
        public readonly ICognitiveSearchServicesBO _cognitiveSearchServicesBO;
        #endregion


        public CognitiveSearchServicesCore(ICognitiveSearchServicesBO cognitiveSearchServicesBO, IConfigurationSettings configuration)
        {
            _cognitiveSearchServicesBO = cognitiveSearchServicesBO;
            _configuration = configuration;
        }
        
        #region Public Method(s)
        public Task<List<CognitiveSearchModel>> Search(string search)
        {
            return  _cognitiveSearchServicesBO.Search(search);
        }
        #endregion  
    }
}
