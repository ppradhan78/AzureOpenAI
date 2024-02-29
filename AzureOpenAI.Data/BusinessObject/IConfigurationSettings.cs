namespace AzureOpenAI.Data.BusinessObject
{
    public interface IConfigurationSettings
    {
        string CognitiveServiceName { get; }
        string CognitiveServiceIndexName { get; }
        string CognitiveServiceApiKey { get; }
    }
}
