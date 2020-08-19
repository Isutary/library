using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class listofroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserModelId",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "390e187f-9f1a-4f0c-af9d-6bfca600045e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "682b106b-bc84-4e6e-854c-709e0071d90e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "455d88c4-b4d0-499f-a49c-be40aefd59a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                column: "ConcurrencyStamp",
                value: "cfb68733-f8ec-44d8-9df0-a1c714cff920");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "f1b837ea-d354-4bab-a26f-604952908a1d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "4aecfbfb-ebdf-4f22-bc8f-4d9173f23b3a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "7eabf01e-b61b-4fa7-8842-e15bdde71ddb");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_UserModelId",
                table: "AspNetRoles",
                column: "UserModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserModelId",
                table: "AspNetRoles",
                column: "UserModelId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_UserModelId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_UserModelId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "UserModelId",
                table: "AspNetRoles");

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
                column: "ConcurrencyStamp",
                value: "fad77bdd-82c6-4aa1-9b72-508f60dbba29");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                column: "ConcurrencyStamp",
                value: "00a6aaeb-2b33-481b-9da6-7e37c28a1081");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                column: "ConcurrencyStamp",
                value: "d7e812b9-b2bb-441c-8f6c-abd99445795c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                column: "ConcurrencyStamp",
                value: "7328cd35-6de0-44a8-a58c-07139fbc0ff7");
        }
    }
}
