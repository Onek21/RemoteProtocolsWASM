using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RemoteProtocolsWASM.Domain.Model;
using RemoteProtocolsWASM.Infrastructure;

[assembly: HostingStartup(typeof(RemoteProtocolsWASM.Server.Areas.Identity.IdentityHostingStartup))]
namespace RemoteProtocolsWASM.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}