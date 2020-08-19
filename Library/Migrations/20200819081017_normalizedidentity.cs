using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class normalizedidentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "313f5c1b-8571-499f-bd82-07db9fcec8c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "4aee2802-f0de-4847-964f-463c6e45ef84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "a2356887-b56b-42dc-9742-13dd5eb59138");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "dc5f5dfb-bb17-4f7f-b03d-d39385c2dd7d", true, "PEPPER@TEST.COM", "PEPPER", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "eeace2e2-6822-4a95-9cee-879c3357ab6e", true, "SALT@TEST.COM", "SALT", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "b185c03a-0693-430f-b421-b8aea664e8b1", true, "ADMIN@TEST.COM", "ADMIN", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "e356f130-89b1-4132-8b20-0258056a5239", true, "TEST@TEST.COM", "TEST", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "bf141d25-c260-4309-b364-cba9b3ab47ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "bae7e87d-5d03-479a-a751-d8053c63fc19");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "3ff0487d-2766-43a2-accf-09d3cf6f4d9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "89ebabc8-f327-42de-a867-9f75f813942a", false, null, null, "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "56584ca7-d5d5-4756-841e-c8f4ffd80d3a", false, null, null, "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "76d26608-a003-4a9e-813e-45b93ebeac29", false, null, null, "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash" },
                values: new object[] { "96e29082-fc4a-4abd-95f2-985a33a3a117", false, null, null, "AQAAAAEAACcQAAAAEE4IWmCoxpOmWx7jusiQx71D2711RJuEhKQWmETOir1u+nHUIJLuY2IDNxQmNItsLQ==" });
        }
    }
}
