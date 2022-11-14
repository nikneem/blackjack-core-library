namespace BlackJack.Core.Configuration;

public class AzureConfiguration
{
    public const string SectionName = "Azure";
    public string StorageAccount { get; set; } = default!;
    public string StorageKey { get; set; } = default!;
    public string WebPubSub { get; set; } = default!;
    public string BlackJackHub { get; set; } = default!;
    public string ServiceBus { get; set; } = default!;
}