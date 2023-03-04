using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AsyncDemo.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 2500, nullable: true),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "10ee7609-a4fb-4612-b4f1-8640c3f2248e", "George", "R R Martin" },
                    { "4028a23e-4b18-4c92-bda9-6c7c803c44eb", "Ken", "Follet" },
                    { "64e4fd63-bae9-4755-be41-c960af184969", "Stephen", "King" },
                    { "72365587-9a11-4e05-8245-117b2349df32", "Conn", "Iggulden" },
                    { "de234a63-3b75-42e3-b2db-e8c19f471bb6", "Bernard", "Cornwell" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "Description", "Title" },
                values: new object[,]
                {
                    { "0e45f98b-4846-4553-9938-7debe5dbf4b9", "64e4fd63-bae9-4755-be41-c960af184969", "Durante as férias de 1958, em uma pacata cidadezinha chamada Derry, um grupo de sete amigos começa a ver coisas estranhas", "It - A Coisa" },
                    { "a743e7d0-444c-4911-ba0f-ce5f8aa6977e", "10ee7609-a4fb-4612-b4f1-8640c3f2248e", "R R Martin", "Fúria dos Reis" },
                    { "c9c465f8-6e47-452a-b670-65dad84acf91", "64e4fd63-bae9-4755-be41-c960af184969", "A Torre Negra, é uma série literária misturando alta fantasia, faroeste, ficção científica e terror numa narrativa que forma um mosaico da cultura popular contemporânea, o enredo segue um pistoleiro e sua busca em direção a uma torre, a Torre Negra, cuja natureza é tanto física quanto metafórica.", "A Torre Negra" },
                    { "e4442934-1f90-458b-8ad8-b6be6433cc29", "10ee7609-a4fb-4612-b4f1-8640c3f2248e", "R R Martin", "Guerra dos Tronos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
