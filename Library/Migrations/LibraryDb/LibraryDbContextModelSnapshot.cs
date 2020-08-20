﻿// <auto-generated />
using System;
using Library.Infrastructure;
using Library.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Migrations.LibraryDb
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Models.AuthorModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Born")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Died")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"),
                            Born = new DateTime(1832, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Died = new DateTime(1898, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Lewis",
                            LastName = "Carroll"
                        },
                        new
                        {
                            Id = new Guid("a78b4e31-d2b2-4ca6-beb8-bade1a65d042"),
                            Born = new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Died = new DateTime(1910, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Leo",
                            LastName = "Tolstoy"
                        },
                        new
                        {
                            Id = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                            Born = new DateTime(1821, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Died = new DateTime(1881, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Fyodor",
                            LastName = "Dostoevsky"
                        },
                        new
                        {
                            Id = new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"),
                            Born = new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Died = new DateTime(1817, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jane",
                            LastName = "Austen"
                        });
                });

            modelBuilder.Entity("Library.Models.BookModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cbb71c00-f577-4702-9575-bdcbe209725e"),
                            AuthorId = new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"),
                            Name = "Alice's Adventures in Wonderland",
                            Published = new DateTime(1865, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("f3f4e9ac-7107-4bdb-95cd-dbd690512704"),
                            AuthorId = new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"),
                            Name = "Through the Looking-Glass",
                            Published = new DateTime(1871, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("a3e45335-5f9e-421e-b889-46e6cfea026d"),
                            AuthorId = new Guid("a78b4e31-d2b2-4ca6-beb8-bade1a65d042"),
                            Name = "War and Peace",
                            Published = new DateTime(1867, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("5af127f6-4468-4599-aaba-49c2c2e15209"),
                            AuthorId = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                            Name = "The Brothers Karamazov",
                            Published = new DateTime(1880, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("1e9ed09e-4b07-4a27-a2cd-64be73a3e85b"),
                            AuthorId = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                            Name = "The Idiot",
                            Published = new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e22024b0-5d64-441b-9ce6-33df0d9f6aae"),
                            AuthorId = new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"),
                            Name = "Demons",
                            Published = new DateTime(1871, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("aab543ba-a513-49a1-8882-652793c09739"),
                            AuthorId = new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"),
                            Name = "Pride and Prejudice",
                            Published = new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("9030cc63-416b-4df0-a2b5-465f836f3cc5"),
                            AuthorId = new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"),
                            Name = "Sense and Sensibility",
                            Published = new DateTime(1811, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Library.Models.BookModel", b =>
                {
                    b.HasOne("Library.Models.AuthorModel", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
