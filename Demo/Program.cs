using System;
using Logic.Graphql.Generated;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddBridgeClient()
                .ConfigureHttpClient(client => client.BaseAddress = new Uri("https://r69u3amow6.execute-api.eu-central-1.amazonaws.com"));
            IServiceProvider services = serviceCollection.BuildServiceProvider();
            IBridgeClient client = services.GetRequiredService<IBridgeClient>();

            var result = await client.GetDetail.ExecuteAsync("Njz3jaQpG6", Currency.Czk);
        }
    }
}
