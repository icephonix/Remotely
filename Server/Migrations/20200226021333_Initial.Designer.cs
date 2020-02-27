﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Remotely.Server.Data;

namespace Remotely.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200226021333_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("character varying(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("RemotelyUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Remotely.Shared.Models.ApiToken", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastUsed")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("Secret")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("Token");

                    b.ToTable("ApiTokens");
                });

            modelBuilder.Entity("Remotely.Shared.Models.CommandContext", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("CommandMode")
                        .HasColumnType("text");

                    b.Property<string>("CommandResults")
                        .HasColumnType("text");

                    b.Property<string>("CommandText")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("PSCoreResults")
                        .HasColumnType("text");

                    b.Property<string>("SenderConnectionID")
                        .HasColumnType("text");

                    b.Property<string>("SenderUserID")
                        .HasColumnType("text");

                    b.Property<string>("TargetDeviceIDs")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("CommandContexts");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Device", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("AgentVersion")
                        .HasColumnType("text");

                    b.Property<string>("Alias")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<double>("CpuUtilization")
                        .HasColumnType("double precision");

                    b.Property<string>("CurrentUser")
                        .HasColumnType("text");

                    b.Property<string>("DeviceGroupID")
                        .HasColumnType("text");

                    b.Property<string>("DeviceName")
                        .HasColumnType("text");

                    b.Property<string>("Drives")
                        .HasColumnType("text");

                    b.Property<bool>("Is64Bit")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastOnline")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OSArchitecture")
                        .HasColumnType("integer");

                    b.Property<string>("OSDescription")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("Platform")
                        .HasColumnType("text");

                    b.Property<int>("ProcessorCount")
                        .HasColumnType("integer");

                    b.Property<string>("ServerVerificationToken")
                        .HasColumnType("text");

                    b.Property<string>("Tags")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<double>("TotalMemory")
                        .HasColumnType("double precision");

                    b.Property<double>("TotalStorage")
                        .HasColumnType("double precision");

                    b.Property<double>("UsedMemory")
                        .HasColumnType("double precision");

                    b.Property<double>("UsedStorage")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.HasIndex("DeviceGroupID");

                    b.HasIndex("DeviceName");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("Remotely.Shared.Models.DeviceGroup", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("DeviceGroups");
                });

            modelBuilder.Entity("Remotely.Shared.Models.EventLog", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("Source")
                        .HasColumnType("text");

                    b.Property<string>("StackTrace")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("EventLogs");
                });

            modelBuilder.Entity("Remotely.Shared.Models.InviteLink", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("InvitedUser")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("ResetUrl")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("InviteLinks");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Organization", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationName")
                        .HasColumnType("character varying(25)")
                        .HasMaxLength(25);

                    b.HasKey("ID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Remotely.Shared.Models.SharedFile", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("ContentType")
                        .HasColumnType("text");

                    b.Property<byte[]>("FileContents")
                        .HasColumnType("bytea");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ID");

                    b.HasIndex("OrganizationID");

                    b.ToTable("SharedFiles");
                });

            modelBuilder.Entity("Remotely.Shared.Models.UserDevicePermission", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("text");

                    b.Property<string>("DeviceGroupID")
                        .HasColumnType("text");

                    b.Property<string>("UserID")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.HasIndex("DeviceGroupID");

                    b.HasIndex("UserID");

                    b.ToTable("PermissionLinks");
                });

            modelBuilder.Entity("Remotely.Shared.Models.RemotelyUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("DeviceGroupID")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdministrator")
                        .HasColumnType("boolean");

                    b.Property<string>("OrganizationID")
                        .HasColumnType("text");

                    b.Property<string>("UserOptions")
                        .HasColumnType("text");

                    b.HasIndex("DeviceGroupID");

                    b.HasIndex("OrganizationID");

                    b.HasIndex("UserName");

                    b.HasDiscriminator().HasValue("RemotelyUser");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Remotely.Shared.Models.ApiToken", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("ApiTokens")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.CommandContext", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("CommandContexts")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.Device", b =>
                {
                    b.HasOne("Remotely.Shared.Models.DeviceGroup", "DeviceGroup")
                        .WithMany("Devices")
                        .HasForeignKey("DeviceGroupID");

                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("Devices")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.DeviceGroup", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("DeviceGroups")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.EventLog", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("EventLogs")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.InviteLink", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("InviteLinks")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.SharedFile", b =>
                {
                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("SharedFiles")
                        .HasForeignKey("OrganizationID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.UserDevicePermission", b =>
                {
                    b.HasOne("Remotely.Shared.Models.DeviceGroup", "DeviceGroup")
                        .WithMany("PermissionLinks")
                        .HasForeignKey("DeviceGroupID");

                    b.HasOne("Remotely.Shared.Models.RemotelyUser", "User")
                        .WithMany("PermissionLinks")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Remotely.Shared.Models.RemotelyUser", b =>
                {
                    b.HasOne("Remotely.Shared.Models.DeviceGroup", null)
                        .WithMany("Users")
                        .HasForeignKey("DeviceGroupID");

                    b.HasOne("Remotely.Shared.Models.Organization", "Organization")
                        .WithMany("RemotelyUsers")
                        .HasForeignKey("OrganizationID");
                });
#pragma warning restore 612, 618
        }
    }
}