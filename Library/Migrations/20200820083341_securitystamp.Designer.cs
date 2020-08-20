﻿// <auto-generated />
using System;
using Library.Infrastructure;
using Library.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations
{
    [DbContext(typeof(LibraryIdentityDbContext))]
    [Migration("20200820083341_securitystamp")]
    partial class securitystamp
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
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525")
                        },
                        new
                        {
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                            PermissionId = new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc")
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
                            ConcurrencyStamp = "5aa973d6-89bf-475c-b04f-411b1006ec78",
                            Email = "salt@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SALT@TEST.COM",
                            NormalizedUserName = "SALT",
                            PasswordHash = "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5e226150-0b0b-4a39-b919-06a496d9df85",
                            TwoFactorEnabled = false,
                            UserName = "Salt"
                        },
                        new
                        {
                            Id = new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eb882f7d-7ee0-4d0b-8aa6-a029845d87a0",
                            Email = "pepper@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PEPPER@TEST.COM",
                            NormalizedUserName = "PEPPER",
                            PasswordHash = "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "729171a5-207f-4218-bfed-bbbfbab5ca8f",
                            TwoFactorEnabled = false,
                            UserName = "Pepper"
                        },
                        new
                        {
                            Id = new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8cf06224-839b-4502-b108-3b539607975c",
                            Email = "test@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@TEST.COM",
                            NormalizedUserName = "TEST",
                            PasswordHash = "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "183fdef4-27bc-4ca0-b89d-799ef3ae84ce",
                            TwoFactorEnabled = false,
                            UserName = "Test"
                        },
                        new
                        {
                            Id = new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cf98cdb2-853d-4479-8a95-b734c6950bf0",
                            Email = "admin@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TEST.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "903362a2-fa4a-436c-992f-c4ba24a55bf9",
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
                        },
                        new
                        {
                            Id = new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136"),
                            Description = "Ability to GET users.",
                            Name = "Users.Search"
                        },
                        new
                        {
                            Id = new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5"),
                            Description = "Ability to POST user.",
                            Name = "Users.Add"
                        },
                        new
                        {
                            Id = new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63"),
                            Description = "Ability to DELTE user.",
                            Name = "Users.Delete"
                        },
                        new
                        {
                            Id = new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab"),
                            Description = "Ability to PUT user.",
                            Name = "Users.Edit"
                        },
                        new
                        {
                            Id = new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e"),
                            Description = "Ability to GET roles.",
                            Name = "Roles.Search"
                        },
                        new
                        {
                            Id = new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab"),
                            Description = "Ability to POST role.",
                            Name = "Roles.Add"
                        },
                        new
                        {
                            Id = new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525"),
                            Description = "Ability to DELTE role.",
                            Name = "Roles.Delete"
                        },
                        new
                        {
                            Id = new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc"),
                            Description = "Ability to PUT role.",
                            Name = "Roles.Edit"
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
                            ConcurrencyStamp = "4200d018-09e5-448e-849f-99cb013e6668",
                            Description = "Role for admin",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                            ConcurrencyStamp = "badabf4b-a0f3-43bb-b639-6d798eb4c1cf",
                            Description = "Role for user",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                            ConcurrencyStamp = "d1c8941f-229d-4002-a326-3179d58243cf",
                            Description = "Role for guest",
                            Name = "Guest",
                            NormalizedName = "GUEST"
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

                    b.HasData(
                        new
                        {
                            UserId = new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                            RoleId = new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d")
                        },
                        new
                        {
                            UserId = new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                            RoleId = new Guid("e371f336-8278-4468-a6c7-373b9f02db52")
                        },
                        new
                        {
                            UserId = new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                            RoleId = new Guid("821764a3-1f57-4413-94aa-a178b26509eb")
                        });
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
