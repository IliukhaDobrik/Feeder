using DataLayer.Interfaces;
using DataLayer.Repositories;
using DataLayer.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataLayerService(this IServiceCollection services)
        {
            services.AddSingleton<IFileManager, FileManager>();
            services.AddSingleton<IFileSystemPathProvider, FileSystemPathProvider>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
