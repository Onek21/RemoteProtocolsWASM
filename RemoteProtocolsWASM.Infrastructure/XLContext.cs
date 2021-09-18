using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RemoteProtocolsWASM.Domain.Model.XLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure
{
    public class XLContext : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public XLContext(DbContextOptions<XLContext> options
           ) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Warehouse>(x => x
            .ToTable("Cdn.Magazyny"));
        }
    }
}
