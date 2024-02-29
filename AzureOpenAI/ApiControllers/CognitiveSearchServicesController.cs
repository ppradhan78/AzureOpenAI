using AzureOpenAI.Data.BusinessObject;
using AzureOpenAI.Data.Core;
using Microsoft.AspNetCore.Mvc;

namespace AzureOpenAI.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CognitiveSearchServicesController : ControllerBase
    {
        #region Global Variable(s)
        private readonly IConfigurationSettings _configuration;
        private readonly ICognitiveSearchServicesCore _cognitiveSearchServicesCore;
        #endregion

        public CognitiveSearchServicesController(ICognitiveSearchServicesCore cognitiveSearchServicesCore, IConfigurationSettings configuration)
        {
            _cognitiveSearchServicesCore = cognitiveSearchServicesCore;
            _configuration = configuration;
        }
       
        #region API Method(s)
        [HttpPost]
        public async Task<IActionResult> Search(string SearchText)
        {
            var response = await _cognitiveSearchServicesCore.Search(SearchText);
            return Ok(response);
        }
        #endregion 
        //[HttpPost]
        //public IActionResult CognitiveSearch(string searchText)
        //{
        //    SearchServiceClient serviceClient = new SearchServiceClient(CognitiveSearchServiceName, new SearchCredentials(CognitiveSearchServiceApiKey));
        //    ISearchIndexClient indexClient = serviceClient.Indexes.GetClient(CognitiveSearchServiceIndex);
        //    SearchParameters parameters = new SearchParameters();
        //    parameters.HighlightFields = new List<string> { "content" };
        //    parameters.HighlightPreTag = "<br/>";
        //    parameters.HighlightPostTag = "<br/>";
        //    var result = indexClient.Documents.SearchAsync(searchText, parameters).Result;
        //    IList<CognitiveSearchModel> searchResult = new List<CognitiveSearchModel>();

        //    foreach (var item in result.Results)
        //    {
        //        var searchModel = new CognitiveSearchModel
        //        {
        //            //FileName = item.Document["metadata_storage_name"].ToString(),
        //            FileText = item.Document["content"].ToString()
        //        };
        //        if (item.Highlights != null)
        //        {
        //            foreach (var data in item.Highlights["content"].ToList())
        //            {
        //                searchModel.HighlightedText += data;
        //            }
        //        }
        //        searchResult.Add(searchModel);
        //    }
        //    return Ok(searchResult);
        //}
    }
}
