using Application.Interface;
using Infrastructure.UnitOfWork.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.SetUp
{
    public static  class InfrastructureSetup
    {
        public static void AddInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));          
        
        }
    }
}
