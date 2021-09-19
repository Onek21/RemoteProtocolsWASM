using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RemoteProtocolsWASM.Application.Services;
using RemoteProtocolsWASM.Application.Interfaces;
using RemoteProtocolsWASM.Shared.Mapping;
using RemoteProtocolsWASM.Application.Interfaces.XLInterface;
using RemoteProtocolsWASM.Application.Services.XLService;

namespace RemoteProtocolsWASM.Application
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<IEventService, EventService>();
            services.AddTransient<IWarehouseService, WarehouseService>();
            services.AddAutoMapper(Assembly.GetAssembly(typeof(MappingProfile)));

            return services;
        }
    }
}
