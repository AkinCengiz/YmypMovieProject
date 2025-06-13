using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddDataCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("09577efc-07f4-40ba-bb20-c4e71c2cabe6"), new DateTime(2025, 6, 13, 18, 38, 26, 82, DateTimeKind.Utc).AddTicks(9717), "", true, false, "Fantastik", null },
                    { new Guid("0ec6fad6-93b9-4f5e-bbd4-44dfa7d2c287"), new DateTime(2025, 6, 13, 18, 38, 26, 82, DateTimeKind.Utc).AddTicks(9706), "", true, false, "Komedi", null },
                    { new Guid("2f766b33-b92f-4a45-8f60-39f6c2f1b81c"), new DateTime(2025, 6, 13, 18, 38, 26, 82, DateTimeKind.Utc).AddTicks(9711), "", true, false, "Belgesel", null },
                    { new Guid("df4ab2c7-25a6-4a3c-bae2-6c96fc1afd32"), new DateTime(2025, 6, 13, 18, 38, 26, 82, DateTimeKind.Utc).AddTicks(9709), "", true, false, "Bilim Kurgu", null },
                    { new Guid("ee33254c-2157-48f6-863f-f833f3b509f4"), new DateTime(2025, 6, 13, 18, 38, 26, 82, DateTimeKind.Utc).AddTicks(9701), "", true, false, "Aksiyon", null },
                    { new Guid("f3d7fbcc-ec96-4b65-87c5-37f5d8bd9674"), new DateTime(2025, 6, 13, 18, 38, 26, 82, DateTimeKind.Utc).AddTicks(9719), "", true, false, "Korku", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09577efc-07f4-40ba-bb20-c4e71c2cabe6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ec6fad6-93b9-4f5e-bbd4-44dfa7d2c287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2f766b33-b92f-4a45-8f60-39f6c2f1b81c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df4ab2c7-25a6-4a3c-bae2-6c96fc1afd32"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee33254c-2157-48f6-863f-f833f3b509f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3d7fbcc-ec96-4b65-87c5-37f5d8bd9674"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
