using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50addda3-1c83-4089-b6a2-3206a9dd148f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4475d2d7-9cc1-464a-827f-e590220067da",
                column: "ConcurrencyStamp",
                value: "cd88ca3a-99ed-4763-96ca-86b748684152");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50addda3-1c83-4089-b6a2-3206a9dd148e", "9f3f5381-419f-4438-9d2d-f5f2893721aa", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4475d2d7-9cc1-464a-827f-e590220067da", 0, "e8e79488-2fb3-4b56-85c8-f1bf4ebecddc", "user@localhost", false, "System", "User", false, null, "USER@LOCALHOST", "USER@LOCALHOST", "AQAAAAEAACcQAAAAEMHKvKBVqszMMGh8ADAb3Gf1kd6IrNM3+ZVoHXheGzIThJPo6uDt7PPC7SwDT6oEAA==", null, false, "", false, "user@localhost" },
                    { "50addda3-1c83-4089-b6a2-3206a9dd148f", 0, "4c3ccfee-0cb4-4ab0-a7f7-74e400ee10e5", "admin@localhost", false, "System", "Admin", false, null, "ADMIN@LOCALHOST", "ADMIN@LOCALHOST", "AQAAAAEAACcQAAAAEELRIE6UamCtj6U/n+nCQcaD4K69OMxS+Hx6tfGTK5ravDGul/YpHEMIJLnFaHZ7pg==", null, false, "", false, "admin@localhost" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(852), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(881), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(884), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(887), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1034), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1038), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1041), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1044), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1150), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1161) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1163), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1164) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1166), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1169), new DateTime(2023, 11, 18, 11, 42, 39, 203, DateTimeKind.Local).AddTicks(1170) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50addda3-1c83-4089-b6a2-3206a9dd148e", "4475d2d7-9cc1-464a-827f-e590220067da" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4475d2d7-9cc1-464a-827f-e590220067da", "50addda3-1c83-4089-b6a2-3206a9dd148f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50addda3-1c83-4089-b6a2-3206a9dd148e", "4475d2d7-9cc1-464a-827f-e590220067da" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4475d2d7-9cc1-464a-827f-e590220067da", "50addda3-1c83-4089-b6a2-3206a9dd148f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50addda3-1c83-4089-b6a2-3206a9dd148e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4475d2d7-9cc1-464a-827f-e590220067da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50addda3-1c83-4089-b6a2-3206a9dd148f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4475d2d7-9cc1-464a-827f-e590220067da",
                column: "ConcurrencyStamp",
                value: "936446de-577a-4950-9355-549841b55b66");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "50addda3-1c83-4089-b6a2-3206a9dd148f", "daca7522-59af-409d-93ad-084f2b9a2bdb", "User", "USER" });

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
    }
}
