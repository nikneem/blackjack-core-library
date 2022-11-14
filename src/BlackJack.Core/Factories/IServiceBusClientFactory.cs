using Azure.Messaging.ServiceBus;

namespace BlackJack.Core.Factories;

public interface IServiceBusClientFactory
{
    ServiceBusSender CreateSender(string queueName);
    ServiceBusReceiver CreateReceiver(string queueName);
}