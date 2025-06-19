using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DirectorModelBuilderCreatedAndAddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "LastName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Directors",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("400e9115-4608-459f-8fab-c73bd0418631"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9392), null, true, false, "Komedi", null },
                    { new Guid("48e012c3-7b40-4b86-96d4-68979a2d2bd1"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9429), null, true, false, "Korku", null },
                    { new Guid("74baf57b-0453-41e9-8490-956e67c8dd7c"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9394), null, true, false, "Bilim Kurgu", null },
                    { new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9381), null, true, false, "Aksiyon", null },
                    { new Guid("f64d6620-f5db-4227-8ead-205d2a5abb6d"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9426), null, true, false, "Fantastik", null },
                    { new Guid("f7164314-d69f-405e-a99d-57c2c324a32b"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9396), null, true, false, "Belgesel", null }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9509), "British-American film director, producer, and screenwriter.", "Christopher", null, true, false, "Nolan", null },
                    { new Guid("2ea0545e-5781-49e0-a645-d5ec6215e50e"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9517), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("33d4ea44-b7ba-4d28-a12c-2de1d9f80c1e"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9524), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("77486892-ba48-456b-81a5-be2452424649"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9519), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("7a4122bf-c0cb-4e9f-9ca7-3d310a5e8c55"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9522), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("400e9115-4608-459f-8fab-c73bd0418631"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48e012c3-7b40-4b86-96d4-68979a2d2bd1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74baf57b-0453-41e9-8490-956e67c8dd7c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f64d6620-f5db-4227-8ead-205d2a5abb6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7164314-d69f-405e-a99d-57c2c324a32b"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2ea0545e-5781-49e0-a645-d5ec6215e50e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("33d4ea44-b7ba-4d28-a12c-2de1d9f80c1e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("77486892-ba48-456b-81a5-be2452424649"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("7a4122bf-c0cb-4e9f-9ca7-3d310a5e8c55"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Directors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

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
    }
}
