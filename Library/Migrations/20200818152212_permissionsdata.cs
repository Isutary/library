using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class permissionsdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetRolePermissions_RoleId",
                table: "AspNetRolePermissions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRolePermissions",
                table: "AspNetRolePermissions",
                columns: new[] { "RoleId", "PermissionId" });

            migrationBuilder.InsertData(
                table: "AspNetRolePermissions",
                columns: new[] { "RoleId", "PermissionId" },
                values: new object[,]
                {
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") },
                    { new Guid("821764a3-1f57-4413-94aa-a178b26509eb"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") },
                    { new Guid("821764a3-1f57-4413-94aa-a178b26509eb"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("c90c27d2-d947-4f4b-884b-a4305083964e") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5") }
                });

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
                column: "ConcurrencyStamp",
                value: "89ebabc8-f327-42de-a867-9f75f813942a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "56584ca7-d5d5-4756-841e-c8f4ffd80d3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "76d26608-a003-4a9e-813e-45b93ebeac29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "96e29082-fc4a-4abd-95f2-985a33a3a117");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRolePermissions",
                table: "AspNetRolePermissions");

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("c90c27d2-d947-4f4b-884b-a4305083964e") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("821764a3-1f57-4413-94aa-a178b26509eb"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("821764a3-1f57-4413-94aa-a178b26509eb"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") });

            migrationBuilder.DeleteData(
                table: "AspNetRolePermissions",
                keyColumns: new[] { "RoleId", "PermissionId" },
                keyValues: new object[] { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5") });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "f5839518-1320-40fb-8f1f-13d9ea40a928");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "a0c4051c-ebdd-4768-a6bc-dae0fddc6d2e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "1de88591-0da0-40d4-8c0d-06f9d3c39b50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                column: "ConcurrencyStamp",
                value: "20e00d7a-6ff1-4c28-b76e-50166b7db3bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "48c3da27-c80e-43bd-b1be-7b3bf6f2a2e1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "d91eb2b8-ad6f-40e3-9ed3-9324406df4a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "dfcf38d9-c93a-491c-a995-27d9d51fe6c4");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRolePermissions_RoleId",
                table: "AspNetRolePermissions",
                column: "RoleId");
        }
    }
}
