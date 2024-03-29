﻿using Microsoft.Extensions.DependencyInjection;

namespace Application.Services.IoC
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IAbilityServices, AbilityServices>();
            services.AddSingleton<IUserServices, UserServices>();
            return services;
        }
    }
}