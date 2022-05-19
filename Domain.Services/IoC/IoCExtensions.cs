using Microsoft.Extensions.DependencyInjection;

namespace Domain.Services.IoC
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddSingleton<IPagerDutyServices, PagerDutyServices>();
            return services;
        }
    }
}