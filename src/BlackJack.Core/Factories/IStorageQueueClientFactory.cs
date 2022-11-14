using Azure.Storage.Queues;

namespace BlackJack.Core.Factories;

public interface IStorageQueueClientFactory
{
    QueueClient CreateClient(string queueName);
}