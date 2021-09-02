﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RemoteProtocolsWASM.Infrastructure;

namespace RemoteProtocolsWASM.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210902192114_AddIsActiveColumn")]
    partial class AddIsActiveColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.AspNetUsersInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Warehouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarehouseDino")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("GroupId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUsersInfo");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActivce")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActivce")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActivce")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActivce")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.MontageProducts", b =>
                {
                    b.Property<int>("MontageProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActivce")
                        .HasColumnType("bit");

                    b.Property<int>("MontageStageId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MontageProductsId");

                    b.HasIndex("MontageStageId");

                    b.ToTable("MontageProducts");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.MontageStage", b =>
                {
                    b.Property<int>("MontageStageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActivce")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MontageStageId");

                    b.ToTable("MontageStages");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Protocol", b =>
                {
                    b.Property<int>("ProtocolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountingSpecialistId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmingPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contractor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractorId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("FaulDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaultRepair")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaultTopic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HardwareName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRepairProtocol")
                        .HasColumnType("bit");

                    b.Property<bool>("IsServiceDeskProtocol")
                        .HasColumnType("bit");

                    b.Property<bool>("Kilometers")
                        .HasColumnType("bit");

                    b.Property<int>("KilometersReturn")
                        .HasColumnType("int");

                    b.Property<int>("KilometersTravel")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManagerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotificationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OnGroupCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentProtocol")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PreparationTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PreparationTimeStop")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProtocolDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProtocolNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProtocolSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProtocolStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ReturnTimeStop")
                        .HasColumnType("datetime2");

                    b.Property<string>("TechnicianId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("TravelTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TravelTimeStop")
                        .HasColumnType("datetime2");

                    b.Property<string>("Warehouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("WorkTimeStart")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("WorkTimeStop")
                        .HasColumnType("datetime2");

                    b.HasKey("ProtocolId");

                    b.HasIndex("AccountingSpecialistId");

                    b.HasIndex("CarId");

                    b.HasIndex("EventId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("ParentProtocol");

                    b.HasIndex("TechnicianId");

                    b.ToTable("Protocols");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.ProtocolNumeration", b =>
                {
                    b.Property<int>("ProtocolNumerationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProtocolMonth")
                        .HasColumnType("int");

                    b.Property<int>("ProtocolNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProtocolYear")
                        .HasColumnType("int");

                    b.HasKey("ProtocolNumerationId");

                    b.ToTable("ProtocolNumeration");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.ProtocolsAssembly", b =>
                {
                    b.Property<int>("ProtocolsAssemblyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DPNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProtocolId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Used")
                        .HasColumnType("bit");

                    b.HasKey("ProtocolsAssemblyId");

                    b.HasIndex("ProtocolId");

                    b.ToTable("ProtocolsAssembly");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.ProtocolsDisassembly", b =>
                {
                    b.Property<int>("ProtocolDisassemblyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DPNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProtocolId")
                        .HasColumnType("int");

                    b.Property<double>("Quantity")
                        .HasColumnType("float");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Used")
                        .HasColumnType("bit");

                    b.HasKey("ProtocolDisassemblyId");

                    b.HasIndex("ProtocolId");

                    b.ToTable("ProtocolsDisassembly");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.AspNetUsersInfo", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.Car", "Car")
                        .WithMany("AspNetUsersInfos")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.Group", "Group")
                        .WithMany("AspNetUsersInfos")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", "Manager")
                        .WithMany("UserManagers")
                        .HasForeignKey("ManagerId");

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", "User")
                        .WithMany("Users")
                        .HasForeignKey("UserId");

                    b.Navigation("Car");

                    b.Navigation("Group");

                    b.Navigation("Manager");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.MontageProducts", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.MontageStage", "MontageStage")
                        .WithMany("MontageProducts")
                        .HasForeignKey("MontageStageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MontageStage");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Protocol", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", "UserAccouting")
                        .WithMany("ProtocolsAccounting")
                        .HasForeignKey("AccountingSpecialistId");

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.Car", "Car")
                        .WithMany("Protocols")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.Event", "Event")
                        .WithMany("Protocols")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", "UserManager")
                        .WithMany("ProtocolsManagers")
                        .HasForeignKey("ManagerId");

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.Protocol", "ParrentsProtocol")
                        .WithMany("ParrentsProtocolCollection")
                        .HasForeignKey("ParentProtocol")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RemoteProtocolsWASM.Domain.Model.User", "UserTechnician")
                        .WithMany("ProtocolsTechnicans")
                        .HasForeignKey("TechnicianId");

                    b.Navigation("Car");

                    b.Navigation("Event");

                    b.Navigation("ParrentsProtocol");

                    b.Navigation("UserAccouting");

                    b.Navigation("UserManager");

                    b.Navigation("UserTechnician");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.ProtocolsAssembly", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.Protocol", "Protocol")
                        .WithMany("ProtocolsAssemblies")
                        .HasForeignKey("ProtocolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Protocol");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.ProtocolsDisassembly", b =>
                {
                    b.HasOne("RemoteProtocolsWASM.Domain.Model.Protocol", "Protocol")
                        .WithMany("ProtocolsDisassemblies")
                        .HasForeignKey("ProtocolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Protocol");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Car", b =>
                {
                    b.Navigation("AspNetUsersInfos");

                    b.Navigation("Protocols");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Event", b =>
                {
                    b.Navigation("Protocols");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Group", b =>
                {
                    b.Navigation("AspNetUsersInfos");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.MontageStage", b =>
                {
                    b.Navigation("MontageProducts");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.Protocol", b =>
                {
                    b.Navigation("ParrentsProtocolCollection");

                    b.Navigation("ProtocolsAssemblies");

                    b.Navigation("ProtocolsDisassemblies");
                });

            modelBuilder.Entity("RemoteProtocolsWASM.Domain.Model.User", b =>
                {
                    b.Navigation("ProtocolsAccounting");

                    b.Navigation("ProtocolsManagers");

                    b.Navigation("ProtocolsTechnicans");

                    b.Navigation("UserManagers");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
