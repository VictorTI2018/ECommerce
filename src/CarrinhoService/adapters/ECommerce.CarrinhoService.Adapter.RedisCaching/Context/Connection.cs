using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace ECommerce.CarrinhoService.Adapter.RedisCaching.Context
{
    public class Connection
    {
        static Connection()
        {
            connectionMultiplexer = new Lazy<ConnectionMultiplexer>(() =>
            {
                return ConnectionMultiplexer.Connect(AppSettings.Settings["Configuracoes:Redis"]);
            });
        }

        private static Lazy<ConnectionMultiplexer> connectionMultiplexer;

        public static ConnectionMultiplexer ConnectionMultiplexer { get { return connectionMultiplexer.Value; } }
    }

    public static class AppSettings
    {
        public static IConfiguration Settings { get; }

        static AppSettings()
        {
            Settings = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
        }
    }
}
