using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4475d2d7-9cc1-464a-827f-e590220067da", "936446de-577a-4950-9355-549841b55b66", "Administrator", "ADMINISTRATOR" },
                    { "50addda3-1c83-4089-b6a2-3206a9dd148f", "daca7522-59af-409d-93ad-084f2b9a2bdb", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4868), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4902), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5067), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5131), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5137), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5150), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 11, 18, 11, 26, 54, 625, DateTimeKind.Local).AddTicks(5158) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4475d2d7-9cc1-464a-827f-e590220067da");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50addda3-1c83-4089-b6a2-3206a9dd148f");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5110), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5113), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5276) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5362), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5366), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5369), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5372), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5375), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5378), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5379) });
        }
    }
}
