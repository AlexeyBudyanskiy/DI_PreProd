using Microsoft.Extensions.DependencyInjection;
using ScreenColor.Common.Interfaces;
using ScreenColor.Common.Services;

namespace ScreenColor.NetCore.Configuration
{
    public static class ServiceExtensions
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            //services.AddTransient<IColorService, BlueService>();
            services.AddScoped<IColorService, GreenService>();
            //services.AddSingleton<IColorService, RedService>();

            return services;
        }
    }
}
