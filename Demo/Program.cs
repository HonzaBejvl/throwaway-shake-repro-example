using System;
using Logic.Graphql.Generated;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using StrawberryShake;

namespace Demo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection
                .AddBridgeClient()
                .ConfigureHttpClient(client =>
                    //displayable schema at https://r69u3amow6.execute-api.eu-central-1.amazonaws.com/schema.graphql
                  client.BaseAddress = new Uri("https://r69u3amow6.execute-api.eu-central-1.amazonaws.com"));
            IServiceProvider services = serviceCollection.BuildServiceProvider();
            IBridgeClient client = services.GetRequiredService<IBridgeClient>();

            var resultPass = await client.GetDetail.ExecuteAsync("L9JmqYPm8Z");
            resultPass.EnsureNoErrors();
        }
    }
}
