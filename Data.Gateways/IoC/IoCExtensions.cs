using System;
using Common.Crosscutting;
using Data.Gateways;
using Microsoft.Extensions.DependencyInjection;

namespace Data.Gateway.PagerDuty.IoC
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddGatewayServices(this IServiceCollection services)
        {
            services
               .AddHttpClient<IPagerDutyGateway, PagerDutyGateway>("PagerDutyClient", (serviceProvider, httpClient) =>
               {
                   var settings = serviceProvider.GetRequiredService<IPagerDutyGatewaySettings>();

                   httpClient.BaseAddress = new Uri(settings.Endpoint);
                   httpClient.DefaultRequestHeaders.Add("Authorization", settings.APIKey);
                   httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.pagerduty+json;version=2");
               }

               );

            return services;
        }
    }
}