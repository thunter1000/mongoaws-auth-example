using MongoDB.Driver;

namespace _20241209MongoAuthExample;

public static class MongoClientServiceCollectionExtensionMethod
{
    public static IServiceCollection AddMongoClient(this IServiceCollection services, ConfigurationMongo mongoConfig)
    {
        services.AddSingleton<IMongoClient>(sp => new MongoClient(MongoClientSettings.FromConnectionString(mongoConfig.ConnectionString)));
        
        
        
        return services;
    }
}