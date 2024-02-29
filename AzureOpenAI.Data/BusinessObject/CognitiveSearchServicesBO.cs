using AzureOpenAI.Data.SampleModel;
using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;

namespace AzureOpenAI.Data.BusinessObject
{
    public class CognitiveSearchServicesBO : ICognitiveSearchServicesBO
    {
        #region Global Variable(s)

        private readonly IConfigurationSettings _configuration;
        #endregion

        public CognitiveSearchServicesBO(IConfigurationSettings configuration)
        {
            _configuration = configuration;
        }
        #region Public Method(s)

        public async Task<List<CognitiveSearchModel>> Search(string search)
        {
            SearchServiceClient serviceClient = new SearchServiceClient(_configuration.CognitiveServiceIndexName, new SearchCredentials(_configuration.CognitiveServiceApiKey));
            ISearchIndexClient indexClient = serviceClient.Indexes.GetClient(_configuration.CognitiveServiceIndexName);
            SearchParameters parameters = new SearchParameters();
            parameters.HighlightFields = new List<string> { "content" };
            parameters.HighlightPreTag = "<br/>";
            parameters.HighlightPostTag = "<br/>";
            var result = indexClient.Documents.SearchAsync(search, parameters).Result;
            List<CognitiveSearchModel> searchResult = new List<CognitiveSearchModel>();

            foreach (var item in result.Results)
            {
                var searchModel = new CognitiveSearchModel
                {
                    //FileName = item.Document["metadata_storage_name"].ToString(),
                    FileText = item.Document["content"].ToString()
                };
                if (item.Highlights != null)
                {
                    foreach (var data in item.Highlights["content"].ToList())
                    {
                        searchModel.HighlightedText += data;
                    }
                }
                searchResult.Add(searchModel);
            }

            return searchResult;
        }
        #endregion

    }
}
