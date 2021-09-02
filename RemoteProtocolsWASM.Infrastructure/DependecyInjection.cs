using Microsoft.Extensions.DependencyInjection;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Application.Services;
using RemoteProtocolsWASM.Domain.Interface;
using RemoteProtocolsWASM.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICarRepository, CarRepository>();
            return services;
        }
    }
}
