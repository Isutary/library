using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class userroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "49bef596-495c-46bf-9ecf-f15f236248b5", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "c64fcd06-d424-4b94-aad5-fdbcb0d6a78b", "GUEST" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "a09dc18f-0ed4-4b3c-b261-e21a9bf9fff6", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"), new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d") },
                    { new Guid("62118166-5017-4732-b744-c59e24dd7a43"), new Guid("e371f336-8278-4468-a6c7-373b9f02db52") },
                    { new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"), new Guid("821764a3-1f57-4413-94aa-a178b26509eb") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                column: "ConcurrencyStamp",
                value: "ef24494f-8f67-4e7a-b66a-20c99cf7d47a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "148d29ef-2825-4eed-ade7-feba6a4a2de4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "1256e0cf-8608-4311-bcdf-b46acfde9050");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "2678b3dc-b92b-4b69-abb7-fa1a460266e1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("62118166-5017-4732-b744-c59e24dd7a43"), new Guid("e371f336-8278-4468-a6c7-373b9f02db52") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"), new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"), new Guid("821764a3-1f57-4413-94aa-a178b26509eb") });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "313f5c1b-8571-499f-bd82-07db9fcec8c0", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "4aee2802-f0de-4847-964f-463c6e45ef84", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "a2356887-b56b-42dc-9742-13dd5eb59138", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                column: "ConcurrencyStamp",
                value: "dc5f5dfb-bb17-4f7f-b03d-d39385c2dd7d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "eeace2e2-6822-4a95-9cee-879c3357ab6e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "b185c03a-0693-430f-b421-b8aea664e8b1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "e356f130-89b1-4132-8b20-0258056a5239");
        }
    }
}
