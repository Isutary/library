using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class securitystamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "30040349-19bb-4d44-b60b-dab4cf893498");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "b26f841c-7785-4ee2-9bd8-09d22cf71759");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "36ef2e20-c22a-4484-8b4c-e06a13667849");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fad77bdd-82c6-4aa1-9b72-508f60dbba29", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00a6aaeb-2b33-481b-9da6-7e37c28a1081", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7e812b9-b2bb-441c-8f6c-abd99445795c", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7328cd35-6de0-44a8-a58c-07139fbc0ff7", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fc480c0-59d1-4093-af26-0c09dbcfa969", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9357ce6b-f0ac-4d4d-9db6-fd7efe5dfa6f", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41c71f00-b5de-4e8c-8688-89898096ce63", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fe7f641-88e0-49b8-9cd8-5a0effe98d1f", null });
        }
    }
}
