using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MovieSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("f64d6620-f5db-4227-8ead-205d2a5abb6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7164314-d69f-405e-a99d-57c2c324a32b"));

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("202f8985-4780-4b06-90b2-63e8b9709201"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4670), null, true, false, "Komedi", null },
                    { new Guid("307fdff0-0d73-4549-bd18-27719148db0d"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4673), null, true, false, "Belgesel", null },
                    { new Guid("588cd130-ff5a-4722-b730-17747c25970b"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4672), null, true, false, "Bilim Kurgu", null },
                    { new Guid("b3eb1edb-e1b6-4c09-832c-4822b03c929b"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4682), null, true, false, "Fantastik", null },
                    { new Guid("f7e4fe8f-c5e2-4227-aa92-d8f839bf1e8b"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4683), null, true, false, "Korku", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2b4ea311-6c84-41a2-8b95-45fc0213bcff"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4782), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("3cbb8fab-b782-4886-8df1-f2ab18ebcfbf"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4778), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("d6e74065-96e6-4de2-aedb-87b3c7ab55f9"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4787), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("fd4ac625-4fc6-4560-a08a-bc22950dd61b"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4783), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("0ac626bd-a319-4e8d-b140-5efc0cb8c3f0"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4803), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bba4f115-686c-435b-9cfd-4fdbee5ec285"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4814), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("cc37527a-3e0a-42f5-91e7-220cad83fa8e"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 6, 19, 18, 50, 1, 642, DateTimeKind.Utc).AddTicks(4810), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("202f8985-4780-4b06-90b2-63e8b9709201"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("307fdff0-0d73-4549-bd18-27719148db0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("588cd130-ff5a-4722-b730-17747c25970b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3eb1edb-e1b6-4c09-832c-4822b03c929b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f7e4fe8f-c5e2-4227-aa92-d8f839bf1e8b"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2b4ea311-6c84-41a2-8b95-45fc0213bcff"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("3cbb8fab-b782-4886-8df1-f2ab18ebcfbf"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("d6e74065-96e6-4de2-aedb-87b3c7ab55f9"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("fd4ac625-4fc6-4560-a08a-bc22950dd61b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("0ac626bd-a319-4e8d-b140-5efc0cb8c3f0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("bba4f115-686c-435b-9cfd-4fdbee5ec285"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("cc37527a-3e0a-42f5-91e7-220cad83fa8e"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IMDB",
                table: "Movies",
                type: "decimal(4,2)",
                precision: 4,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(4,2)",
                oldPrecision: 4,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("400e9115-4608-459f-8fab-c73bd0418631"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9392), null, true, false, "Komedi", null },
                    { new Guid("48e012c3-7b40-4b86-96d4-68979a2d2bd1"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9429), null, true, false, "Korku", null },
                    { new Guid("74baf57b-0453-41e9-8490-956e67c8dd7c"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9394), null, true, false, "Bilim Kurgu", null },
                    { new Guid("f64d6620-f5db-4227-8ead-205d2a5abb6d"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9426), null, true, false, "Fantastik", null },
                    { new Guid("f7164314-d69f-405e-a99d-57c2c324a32b"), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9396), null, true, false, "Belgesel", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"),
                column: "CreateAt",
                value: new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("2ea0545e-5781-49e0-a645-d5ec6215e50e"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9517), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("33d4ea44-b7ba-4d28-a12c-2de1d9f80c1e"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9524), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null },
                    { new Guid("77486892-ba48-456b-81a5-be2452424649"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9519), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("7a4122bf-c0cb-4e9f-9ca7-3d310a5e8c55"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 19, 17, 56, 16, 448, DateTimeKind.Utc).AddTicks(9522), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null }
                });
        }
    }
}
