using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class extendedpermissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "c98ab27f-b2c4-4159-85ea-b1f63cc28660");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "908538f0-ac84-4d09-9734-fcdf497b8916");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "51d8bdaf-a221-4a86-a40c-6054debaa5e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                column: "ConcurrencyStamp",
                value: "7fc480c0-59d1-4093-af26-0c09dbcfa969");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "9357ce6b-f0ac-4d4d-9db6-fd7efe5dfa6f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "41c71f00-b5de-4e8c-8688-89898096ce63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "8fe7f641-88e0-49b8-9cd8-5a0effe98d1f");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136"), "Ability to GET users.", "Users.Search" },
                    { new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5"), "Ability to POST user.", "Users.Add" },
                    { new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63"), "Ability to DELTE user.", "Users.Delete" },
                    { new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab"), "Ability to PUT user.", "Users.Edit" },
                    { new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e"), "Ability to GET roles.", "Roles.Search" },
                    { new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab"), "Ability to POST role.", "Roles.Add" },
                    { new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525"), "Ability to DELTE role.", "Roles.Delete" },
                    { new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc"), "Ability to PUT role.", "Roles.Edit" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRolePermissions",
                columns: new[] { "RoleId", "PermissionId" },
                values: new object[,]
                {
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5") });

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "49bef596-495c-46bf-9ecf-f15f236248b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "c64fcd06-d424-4b94-aad5-fdbcb0d6a78b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "a09dc18f-0ed4-4b3c-b261-e21a9bf9fff6");

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
    }
}
