using MongoDB.Driver;

namespace _20241209MongoAuthExample;

public class MongoTestService(IMongoClient mongoClient, ILogger<MongoTestService> logger) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var dbList = await mongoClient.ListDatabaseNamesAsync(stoppingToken);
            logger.LogInformation("DB LIST {dblist}", String.Join(", ", dbList.ToList()));
            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}