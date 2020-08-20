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
                value: "4200d018-09e5-448e-849f-99cb013e6668");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "d1c8941f-229d-4002-a326-3179d58243cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "badabf4b-a0f3-43bb-b639-6d798eb4c1cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb882f7d-7ee0-4d0b-8aa6-a029845d87a0", "729171a5-207f-4218-bfed-bbbfbab5ca8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5aa973d6-89bf-475c-b04f-411b1006ec78", "5e226150-0b0b-4a39-b919-06a496d9df85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf98cdb2-853d-4479-8a95-b734c6950bf0", "903362a2-fa4a-436c-992f-c4ba24a55bf9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cf06224-839b-4502-b108-3b539607975c", "183fdef4-27bc-4ca0-b89d-799ef3ae84ce" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("79293f5d-c7ce-4ea0-8a19-816571e14c4d"),
                column: "ConcurrencyStamp",
                value: "e7dd0ad8-3db8-4a2c-b806-5e63fafb2698");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("821764a3-1f57-4413-94aa-a178b26509eb"),
                column: "ConcurrencyStamp",
                value: "a9df1c64-95f9-4c50-9abd-7298e2bb96dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e371f336-8278-4468-a6c7-373b9f02db52"),
                column: "ConcurrencyStamp",
                value: "197266c5-d8d1-4fe4-bd63-a2372ffbe0a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("62118166-5017-4732-b744-c59e24dd7a43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff264bdb-9659-4b45-a957-fb2b4af2e9ed", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("816dc3ef-fa81-47f4-82f5-a99b60f5ea8e"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11852dbf-eb77-4419-969f-de2d82ea865c", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d82d7385-c6b1-4090-8128-7695c4a83f50"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87e575f3-22a1-4e90-bb11-2eb501bcbec6", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f3e8124a-e6eb-40dd-adfd-976df7f6b447"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d937168-25e5-474f-84b6-e980a8cc5a32", "NLHXZH3VAIQEPRBKCHKGEJTM2TXSQZZK" });
        }
    }
}
