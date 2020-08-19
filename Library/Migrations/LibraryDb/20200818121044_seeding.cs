using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations.LibraryDb
{
    public partial class seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Born = table.Column<DateTime>(nullable: false),
                    Died = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: false),
                    Published = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Born", "Died", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"), new DateTime(1832, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1898, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lewis", "Carroll" },
                    { new Guid("a78b4e31-d2b2-4ca6-beb8-bade1a65d042"), new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1910, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo", "Tolstoy" },
                    { new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"), new DateTime(1821, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1881, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fyodor", "Dostoevsky" },
                    { new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"), new DateTime(1775, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1817, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Austen" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Name", "Published" },
                values: new object[,]
                {
                    { new Guid("cbb71c00-f577-4702-9575-bdcbe209725e"), new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"), "Alice's Adventures in Wonderland", new DateTime(1865, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3f4e9ac-7107-4bdb-95cd-dbd690512704"), new Guid("8ff6c943-c1fc-4d71-9e7a-05d474fad866"), "Through the Looking-Glass", new DateTime(1871, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3e45335-5f9e-421e-b889-46e6cfea026d"), new Guid("a78b4e31-d2b2-4ca6-beb8-bade1a65d042"), "War and Peace", new DateTime(1867, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5af127f6-4468-4599-aaba-49c2c2e15209"), new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"), "The Brothers Karamazov", new DateTime(1880, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e9ed09e-4b07-4a27-a2cd-64be73a3e85b"), new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"), "The Idiot", new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e22024b0-5d64-441b-9ce6-33df0d9f6aae"), new Guid("8b48a5e8-e0a1-474d-afcf-33859dafb42d"), "Demons", new DateTime(1871, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aab543ba-a513-49a1-8882-652793c09739"), new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"), "Pride and Prejudice", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9030cc63-416b-4df0-a2b5-465f836f3cc5"), new Guid("f9f011f8-e216-4ec5-95ea-a64c85d703bb"), "Sense and Sensibility", new DateTime(1811, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
