using Application.Interface;
using Domain.Context;
using Infrastructure.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Infrastructure.SetUp
{
    public static class InfrastructureSetup
    {
      
        public static void AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<UnitOfWork>();
            services.AddScoped<UnitOfWork2>();
          
            services.AddTransient<Func<string, IUnitOfWork>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "1":
                        return serviceProvider.GetService<UnitOfWork>();
                    case "2":
                        return serviceProvider.GetService<UnitOfWork2>();
                    default:
                        return serviceProvider.GetService<UnitOfWork2>();
                }
            });

        }
        public static void AddApplicationDBContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

        }
    }
}
