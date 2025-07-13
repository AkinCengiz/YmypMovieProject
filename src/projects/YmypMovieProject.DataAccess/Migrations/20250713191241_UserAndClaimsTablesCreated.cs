using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YmypMovieProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UserAndClaimsTablesCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationClaimId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "Description", "IsActive", "IsDeleted", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("00627020-63ca-44ba-85d2-67fa5f63cfe3"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9265), null, true, false, "Bilim Kurgu", null },
                    { new Guid("4d31a26f-c8a2-4d46-8b1c-65f4bcf2fb00"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9268), null, true, false, "Fantastik", null },
                    { new Guid("65d22660-2b45-44cd-a2e6-370e5921bd8b"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9254), null, true, false, "Komedi", null },
                    { new Guid("7f4d5cd6-9169-417d-9bc0-241f512fefd8"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9267), null, true, false, "Belgesel", null },
                    { new Guid("ac0a2026-0e19-4210-a49f-5b06001f1b71"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9270), null, true, false, "Korku", null }
                });

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"),
                column: "CreateAt",
                value: new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9373));

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "BirthDate", "CreateAt", "Description", "FirstName", "ImageUrl", "IsActive", "IsDeleted", "LastName", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("1033027a-01f3-45ae-8153-31326dcdbb7e"), new DateTime(1963, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9387), "American filmmaker, actor, and screenwriter.", "Quentin", null, true, false, "Tarantino", null },
                    { new Guid("8729f57a-205a-4ae7-b3dd-edc1fca3b27a"), new DateTime(1946, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9382), "American film director, producer, and screenwriter.", "Steven", null, true, false, "Spielberg", null },
                    { new Guid("87c663c9-24f1-4250-8e5a-d909f31eb23a"), new DateTime(1942, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9385), "American film director, producer, screenwriter, and actor.", "Martin", null, true, false, "Scorsese", null },
                    { new Guid("f56d7045-0c15-44fd-8abd-e063eb77c382"), new DateTime(1954, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9388), "Canadian filmmaker and environmental advocate.", "James", null, true, false, "Cameron", null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CategoryId", "CreateAt", "Description", "DirectorId", "IMDB", "ImageUrl", "IsActive", "IsDeleted", "Name", "PublishDate", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("4bfc9e36-5e81-4da3-af66-d840a4633d45"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9405), "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.8m, null, true, false, "Inception", new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("7caea67d-dbdc-4c16-b083-664f6f299027"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9416), "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 8.6m, null, true, false, "Interstellar", new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e0948a0b-a030-4b4e-81ab-664174189291"), new Guid("7fe0ac2b-fa60-4004-a579-c5967a1746a1"), new DateTime(2025, 7, 13, 19, 12, 41, 350, DateTimeKind.Utc).AddTicks(9413), "When the menace known as the Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.", new Guid("2950d635-d293-4c82-a9fb-f23f8cfa5956"), 9.0m, null, true, false, "The Dark Knight", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00627020-63ca-44ba-85d2-67fa5f63cfe3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d31a26f-c8a2-4d46-8b1c-65f4bcf2fb00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("65d22660-2b45-44cd-a2e6-370e5921bd8b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f4d5cd6-9169-417d-9bc0-241f512fefd8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac0a2026-0e19-4210-a49f-5b06001f1b71"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("1033027a-01f3-45ae-8153-31326dcdbb7e"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("8729f57a-205a-4ae7-b3dd-edc1fca3b27a"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("87c663c9-24f1-4250-8e5a-d909f31eb23a"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("f56d7045-0c15-44fd-8abd-e063eb77c382"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4bfc9e36-5e81-4da3-af66-d840a4633d45"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("7caea67d-dbdc-4c16-b083-664f6f299027"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e0948a0b-a030-4b4e-81ab-664174189291"));

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
    }
}
