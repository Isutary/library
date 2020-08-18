using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations.LibraryIdentityDb
{
    public partial class Permissions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRolePermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    RoleId1 = table.Column<string>(nullable: true),
                    PermissionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetRolePermissions_AspNetRoles_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRolePermissions_PermissionId",
                table: "AspNetRolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRolePermissions_RoleId1",
                table: "AspNetRolePermissions",
                column: "RoleId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRolePermissions");

            migrationBuilder.DropTable(
                name: "Permissions");
        }
    }
}
