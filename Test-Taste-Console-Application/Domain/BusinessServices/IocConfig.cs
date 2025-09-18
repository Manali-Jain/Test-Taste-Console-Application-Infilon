using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Taste_Console_Application.Domain.Services;
using Test_Taste_Console_Application.Domain.Services.Interfaces;

namespace Test_Taste_Console_Application.Domain.BusinessServices
{


    internal static class IocConfig
    {
        /// <summary>
        /// Configures all dependencies for the application.
        /// </summary>
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddHttpClient<HttpClientService>();

            // Register MemoryCache
            services.AddMemoryCache();

            // Register services
            services.AddSingleton<IPlanetService, PlanetService>();
            services.AddSingleton<IMoonService, MoonService>();
        }
    }
}
