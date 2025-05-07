using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "Author", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Miles Kelly", 250.00m, "Encyclopedia Of Life" },
                    { 2, "Roald Dahl", 345.68m, "Matilda" },
                    { 3, "Jeff Kinney", 199.99m, "Diary of a Wimpy Kid" },
                    { 4, "Jannie Putter", 189.50m, "Secrets of a Champion" },
                    { 5, "Lauren Kate", 225.75m, "Fallen" },
                    { 6, "Jeff Kinney", 210.00m, "Diary of a Wimpy Kid: Rodrick Rules" },
                    { 7, "Jeff Kinney", 205.50m, "Diary of a Wimpy Kid: The Last Straw" },
                    { 8, "Jeff Kinney", 215.75m, "Diary of a Wimpy Kid: Dog Days" },
                    { 9, "Friedrich Nietzsche", 310.99m, "The Birth of Tragedy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
