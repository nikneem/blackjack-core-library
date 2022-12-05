namespace BlackJack.Core.Configuration;

public class AzureConfiguration
{
    public const string SectionName = "Azure";
    public string StorageAccount { get; set; } = null!;
    public string StorageKey { get; set; } = null!;
    public string WebPubSub { get; set; } = null!;
    public string BlackJackHub { get; set; } = null!;
    public string ServiceBus { get; set; } = null!;
    public string EventGridTopicEndpoint { get; set; } = null!;
}