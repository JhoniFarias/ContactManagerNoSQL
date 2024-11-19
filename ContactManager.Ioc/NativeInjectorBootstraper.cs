using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace ContactManager.Ioc
{
    public static class NativeInjectorBootstraper
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddSingleton<IMongoClient,MongoClient>(sp => new MongoClient(builder.Configuration.GetConnectionString("mongodb")));
        }
    }
}
