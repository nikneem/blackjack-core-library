using Azure.Identity;
using Azure.Storage.Queues;
using BlackJack.Core.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BlackJack.Core.Factories;

public class StorageQueueClientFactory : IStorageQueueClientFactory
{

    private readonly string _accountName;
    
    public QueueClient CreateClient(string queueName)
    {
        var identity = new DefaultAzureCredential();
        var queueStorageUri = new Uri($"https://{_accountName}.queue.core.windows.net/{queueName}");
        return new QueueClient(queueStorageUri, identity);
    }

    public StorageQueueClientFactory(IOptions<AzureConfiguration> options, ILogger<StorageQueueClientFactory> logger)
    {
        _accountName = options.Value.StorageAccount;
    }
}