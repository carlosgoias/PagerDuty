using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Common.Crosscutting.IoC
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddCommonCrosscuttingServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IPagerDutyGatewaySettings>(configuration
                .GetSection(PagerDutyGatewaySettings.SettingPath)
                .Get<PagerDutyGatewaySettings>());

            return services;
        }
    }
}