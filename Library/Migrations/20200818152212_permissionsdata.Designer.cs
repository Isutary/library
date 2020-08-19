﻿// <auto-generated />
using System;
using Library.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(LibraryIdentityDbContext))]
    [Migration("20200818152212_permissionsdata")]
    partial class permissionsdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.AspNetRolePermission", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("AspNetRolePermissions");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("c90c27d2-d947-4f4b-884b-a4305083964e")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("50bbb8c8-d49c-4da1-8690-35f555334731")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa")
                        },
                        new
                        {
                            RoleId = new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                            PermissionId = new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd")
                        },
                        new
                        {
                            RoleId = new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                            PermissionId = new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f")
                        },
                        new
                        {
                            RoleId = new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                            PermissionId = new Guid("50bbb8c8-d49c-4da1-8690-35f555334731")
                        },
                        new
                        {
                            RoleId = new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                            PermissionId = new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5")
                        },
                        new
                        {
                            RoleId = new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                            PermissionId = new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd")
                        },
                        new
                        {
                            RoleId = new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                            PermissionId = new Guid("50bbb8c8-d49c-4da1-8690-35f555334731")
                        });
                });

            modelBuilder.Entity("Library.Models.Identity.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "56584ca7-d5d5-4756-841e-c8f4ffd80d3a",
                            Email = "salt@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Salt"
                        },
                        new
                        {
                            Id = new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "89ebabc8-f327-42de-a867-9f75f813942a",
                            Email = "pepper@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Pepper"
                        },
                        new
                        {
                            Id = new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "96e29082-fc4a-4abd-95f2-985a33a3a117",
                            Email = "test@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Test"
                        },
                        new
                        {
                            Id = new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "76d26608-a003-4a9e-813e-45b93ebeac29",
                            Email = "admin@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Library.Models.PermissionModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd"),
                            Description = "Ability to GET author.",
                            Name = "Authors.Search"
                        },
                        new
                        {
                            Id = new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f"),
                            Description = "Ability to POST author.",
                            Name = "Authors.Add"
                        },
                        new
                        {
                            Id = new Guid("c90c27d2-d947-4f4b-884b-a4305083964e"),
                            Description = "Ability to DELETE author.",
                            Name = "Authors.Delete"
                        },
                        new
                        {
                            Id = new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0"),
                            Description = "Ability to PUT author.",
                            Name = "Authors.Edit"
                        },
                        new
                        {
                            Id = new Guid("50bbb8c8-d49c-4da1-8690-35f555334731"),
                            Description = "Ability to GET books.",
                            Name = "Books.Search"
                        },
                        new
                        {
                            Id = new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5"),
                            Description = "Ability to POST book.",
                            Name = "Books.Add"
                        },
                        new
                        {
                            Id = new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5"),
                            Description = "Ability to DELTE book.",
                            Name = "Books.Delete"
                        },
                        new
                        {
                            Id = new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa"),
                            Description = "Ability to PUT book.",
                            Name = "Books.Edit"
                        });
                });

            modelBuilder.Entity("Library.Models.Roles.RoleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            ConcurrencyStamp = "bf141d25-c260-4309-b364-cba9b3ab47ba",
                            Description = "Role for admin",
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                            ConcurrencyStamp = "3ff0487d-2766-43a2-accf-09d3cf6f4d9d",
                            Description = "Role for user",
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                            ConcurrencyStamp = "bae7e87d-5d03-479a-a751-d8053c63fc19",
                            Description = "Role for guest",
                            Name = "Guest"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Library.Models.AspNetRolePermission", b =>
                {
                    b.HasOne("Library.Models.PermissionModel", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.Roles.RoleModel", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Library.Models.Roles.RoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Library.Models.Identity.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Library.Models.Identity.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Library.Models.Roles.RoleModel", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Models.Identity.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Library.Models.Identity.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
