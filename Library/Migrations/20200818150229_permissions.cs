using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class permissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRolePermissions",
                table: "AspNetRolePermissions");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AspNetRolePermissions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "1bf7c5e1-13d3-4d93-ab22-3db1054cf4bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "450bc5b4-dfa1-4b75-b523-4e168cf50673");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "74f4641a-848e-448c-8c22-a3c636a329b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                column: "ConcurrencyStamp",
                value: "e7a4c4a3-d567-4179-b1d3-5706809c14ef");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "5f6f9877-60a8-41b3-ba1b-5be1aa8d1d37");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "0577dbc0-fe8e-4851-9175-28fed441086c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "73654d66-b270-455c-9d27-33bd1f07bcaa");

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd"), "Ability to GET author.", "Authors.Search" },
                    { new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f"), "Ability to POST author.", "Authors.Add" },
                    { new Guid("c90c27d2-d947-4f4b-884b-a4305083964e"), "Ability to DELETE author.", "Authors.Delete" },
                    { new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0"), "Ability to PUT author.", "Authors.Edit" },
                    { new Guid("50bbb8c8-d49c-4da1-8690-35f555334731"), "Ability to GET books.", "Books.Search" },
                    { new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5"), "Ability to POST book.", "Books.Add" },
                    { new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5"), "Ability to DELTE book.", "Books.Delete" },
                    { new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa"), "Ability to PUT book.", "Books.Edit" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("50bbb8c8-d49c-4da1-8690-35f555334731"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("c90c27d2-d947-4f4b-884b-a4305083964e"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "AspNetRolePermissions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRolePermissions",
                table: "AspNetRolePermissions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "52632652-0533-4066-bbc5-3a1d8e2b45b6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "34ff1c21-99fe-42b9-a526-33d61d744738");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "c1d688ec-83bb-49fb-9e05-580b02f3fc3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                column: "ConcurrencyStamp",
                value: "bb48d16e-0124-4be3-a45b-3a501838fbd8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "462d71f7-83f5-497d-9b51-36550fc914a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "8bc53f5b-fb3c-49ed-9b2c-690076681e04");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "09311fe6-f086-4e86-a479-953723f44d9d");
        }
    }
}
