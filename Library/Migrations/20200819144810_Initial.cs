using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRolePermissions",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    PermissionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRolePermissions", x => new { x.RoleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_AspNetRolePermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetRolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("821764a3-1f57-4413-94aa-a178b26509eb"), "a9df1c64-95f9-4c50-9abd-7298e2bb96dd", "Role for guest", "Guest", "GUEST" },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), "e7dd0ad8-3db8-4a2c-b806-5e63fafb2698", "Role for admin", "Admin", "ADMIN" },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), "197266c5-d8d1-4fe4-bd63-a2372ffbe0a7", "Role for user", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"), 0, "11852dbf-eb77-4419-969f-de2d82ea865c", "salt@test.com", true, false, null, "SALT@TEST.COM", "SALT", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==", null, false, "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK", false, "Salt" },
                    { new Guid("62118166-5017-4732-b744-c59e24dd7a43"), 0, "ff264bdb-9659-4b45-a957-fb2b4af2e9ed", "pepper@test.com", true, false, null, "PEPPER@TEST.COM", "PEPPER", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==", null, false, "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK", false, "Pepper" },
                    { new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"), 0, "2d937168-25e5-474f-84b6-e980a8cc5a32", "test@test.com", true, false, null, "TEST@TEST.COM", "TEST", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==", null, false, "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK", false, "Test" },
                    { new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"), 0, "87e575f3-22a1-4e90-bb11-2eb501bcbec6", "admin@test.com", true, false, null, "ADMIN@TEST.COM", "ADMIN", "AQAAAAEAACcQAAAAEKZoIra5WAb7uXMVE/zAQZqL2a/2FO6cLEfZ2pGD86ejnCZ7/ScTahv5zWu1MRk6rw==", null, false, "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK", false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd"), "Ability to GET author.", "Authors.Search" },
                    { new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc"), "Ability to PUT role.", "Roles.Edit" },
                    { new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525"), "Ability to DELTE role.", "Roles.Delete" },
                    { new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab"), "Ability to POST role.", "Roles.Add" },
                    { new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e"), "Ability to GET roles.", "Roles.Search" },
                    { new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab"), "Ability to PUT user.", "Users.Edit" },
                    { new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63"), "Ability to DELTE user.", "Users.Delete" },
                    { new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5"), "Ability to POST user.", "Users.Add" },
                    { new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5"), "Ability to DELTE book.", "Books.Delete" },
                    { new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5"), "Ability to POST book.", "Books.Add" },
                    { new Guid("50bbb8c8-d49c-4da1-8690-35f555334731"), "Ability to GET books.", "Books.Search" },
                    { new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0"), "Ability to PUT author.", "Authors.Edit" },
                    { new Guid("c90c27d2-d947-4f4b-884b-a4305083964e"), "Ability to DELETE author.", "Authors.Delete" },
                    { new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f"), "Ability to POST author.", "Authors.Add" },
                    { new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136"), "Ability to GET users.", "Users.Search" },
                    { new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa"), "Ability to PUT book.", "Books.Edit" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRolePermissions",
                columns: new[] { "RoleId", "PermissionId" },
                values: new object[,]
                {
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") },
                    { new Guid("821764a3-1f57-4413-94aa-a178b26509eb"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f") },
                    { new Guid("e371f336-8278-4468-a6c7-373b9f02db52"), new Guid("ce607a0b-0e3e-4a9e-8dad-fbc0cbd08fcd") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("805ae7b9-a834-4e1a-a2c0-88d8d4f3b1cc") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("05e8d3d1-bef0-48b1-a5d9-da6d4a90d525") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("8c247bbd-a6f3-4b2a-b86b-262d9cd6b9ab") },
                    { new Guid("821764a3-1f57-4413-94aa-a178b26509eb"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("84d4cc27-b676-4a5c-83fa-8d5f83a9efab") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("9e790d82-e3b4-477e-8bf6-a33b6f023c9e") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("d9b94b59-468a-4a57-aab1-04c27150a6c5") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("6713b9bd-7e6a-4780-84be-05f0092dc136") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("27055641-e188-4e0f-afae-4dfd60d1b3fa") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("2ac2829b-2c9b-4626-a47c-73d3dd46a6e5") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("de2623c0-e624-4a5f-9afa-08e99a0867b5") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("50bbb8c8-d49c-4da1-8690-35f555334731") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("5dfdf747-a9c8-4186-9816-053fe86b43a0") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("c90c27d2-d947-4f4b-884b-a4305083964e") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("41e8d73a-a59d-4387-a949-85265a7b2f7f") },
                    { new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"), new Guid("18a09a24-67f4-44fe-8993-17c9aa7bbd63") }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"), new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d") },
                    { new Guid("62118166-5017-4732-b744-c59e24dd7a43"), new Guid("e371f336-8278-4468-a6c7-373b9f02db52") },
                    { new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"), new Guid("821764a3-1f57-4413-94aa-a178b26509eb") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRolePermissions_PermissionId",
                table: "AspNetRolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRolePermissions");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
