using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5104), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5108), "White", "System" },
                    { 3, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5110), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5111), "Red", "System" },
                    { 4, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5113), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5114), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5270), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5273), "Toyota", "System" },
                    { 2, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5276), "Honda", "System" },
                    { 3, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5280), "Ford", "System" },
                    { 4, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5283), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5357), "Camry", "System" },
                    { 2, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5361), "Corolla", "System" },
                    { 3, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5362), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5364), "Accord", "System" },
                    { 4, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5366), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5367), "Civic", "System" },
                    { 5, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5369), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5370), "Focus", "System" },
                    { 6, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5372), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5373), "Mustang", "System" },
                    { 7, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5375), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5376), "X5", "System" },
                    { 8, "System", new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5378), new DateTime(2023, 11, 18, 11, 19, 21, 967, DateTimeKind.Local).AddTicks(5379), "X7", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
