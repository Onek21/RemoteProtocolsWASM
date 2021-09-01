using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RemoteProtocolsWASM.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteProtocolsWASM.Infrastructure
{
    public class Context : ApiAuthorizationDbContext<User>
    {
        public DbSet<AspNetUsersInfo> AspNetUsersInfo { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MontageProducts> MontageProducts { get; set; }
        public DbSet<MontageStage> MontageStages { get; set; }
        public DbSet<ProtocolNumeration> ProtocolNumeration { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<ProtocolsAssembly> ProtocolsAssembly { get; set; }
        public DbSet<ProtocolsDisassembly> ProtocolsDisassembly { get; set; }

        public Context(DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AspNetUsersInfo>()
                .HasOne<Car>(it => it.Car).WithMany(i => i.AspNetUsersInfos)
                .HasForeignKey(k => k.CarId);

            builder.Entity<AspNetUsersInfo>()
                .HasOne<Group>(it => it.Group).WithMany(i => i.AspNetUsersInfos)
                .HasForeignKey(k => k.GroupId);

            builder.Entity<AspNetUsersInfo>()
                .HasOne<User>(it => it.User).WithMany(i => i.Users)
                .HasForeignKey(k => k.UserId);

            builder.Entity<AspNetUsersInfo>()
                .HasOne<User>(it => it.Manager).WithMany(i => i.UserManagers)
                .HasForeignKey(k => k.ManagerId);

            builder.Entity<MontageProducts>()
                .HasOne<MontageStage>(it => it.MontageStage).WithMany(i => i.MontageProducts)
                .HasForeignKey(k => k.MontageStageId);

            builder.Entity<Protocol>()
                .HasOne(it => it.UserAccouting).WithMany(i => i.ProtocolsAccounting)
                .HasForeignKey(k => k.AccountingSpecialistId);


            builder.Entity<Protocol>()
                .HasOne(it => it.UserTechnician).WithMany(i => i.ProtocolsTechnicans)
                .HasForeignKey(k => k.TechnicianId);

            builder.Entity<Protocol>()
                .HasOne(it => it.UserManager).WithMany(i => i.ProtocolsManagers)
                .HasForeignKey(k => k.ManagerId);

            builder.Entity<Protocol>()
                .HasOne(it => it.Car).WithMany(i => i.Protocols)
                .HasForeignKey(k => k.CarId);

            builder.Entity<Protocol>()
                .HasOne(it => it.Event).WithMany(i => i.Protocols)
                .HasForeignKey(k => k.EventId);

            builder.Entity<Protocol>()
                .HasOne(it => it.ParrentsProtocol).WithMany(i => i.ParrentsProtocolCollection)
                .HasForeignKey(k => k.ParentProtocol)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<ProtocolsAssembly>()
                .HasKey(x => x.ProtocolsAssemblyId);

            builder.Entity<ProtocolsDisassembly>()
                .HasKey(x => x.ProtocolDisassemblyId);
        }
    }
}
