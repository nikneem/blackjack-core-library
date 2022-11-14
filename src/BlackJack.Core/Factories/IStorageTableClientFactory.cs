using Azure.Data.Tables;

namespace BlackJack.Core.Factories;

public interface IStorageTableClientFactory
{
    TableClient CreateClient(string tableName);
}