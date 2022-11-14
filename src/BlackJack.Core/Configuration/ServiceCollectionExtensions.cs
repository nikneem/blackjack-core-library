using BlackJack.Core.Factories;
using BlackJack.Core.HealthChecks;
using HexMaster.Randomizer.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlackJack.Core.Configuration;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlackJackCore(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHealthChecks()
            .AddCheck<StorageAccountHealthCheck>("StorageAccountHealthCheck");

        services.AddTransient<IServiceBusClientFactory, ServiceBusClientFactory>();
        services.AddTransient<IStorageQueueClientFactory, StorageQueueClientFactory>();
        services.AddTransient<IStorageTableClientFactory, StorageTableClientFactory>();

        services.AddRandomizer();
        services.Configure<AzureConfiguration>(configuration.GetSection(AzureConfiguration.SectionName));
        return services;
    }
}