using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movie_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Actors", "Description", "Title" },
                values: new object[] { "Brody Walker", "Former SWAT leader David Hendrix and hard-partying movie star Brody Walker must cut their ride-along short when a police training facility is attacked by a team of mercenaries.", "Gridlocked" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Actors", "Description", "Title" },
                values: new object[] { "Antonio Banderas", "A security guard protects an eleven year-old girl who is being targeted by a gang for participating as a trial witness.", "Security" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Actors", "Description", "Title" },
                values: new object[] { "Liam Neeson", "Travis Block is a government operative coming to terms with his shadowy past. When he discovers a plot targeting U.S. citizens, Block finds himself in the crosshairs of the FBI director he once helped protect.", "Blacklight" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Actors", "Description", "Title" },
                values: new object[] { "john wick", "With the price on his head ever increasing, legendary hit man John Wick takes his fight against the High Table global as he seeks out the most powerful players in the underworld, from New York to Paris to Japan to Berlin.", "John Wick 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Actors", "Description", "Title" },
                values: new object[] { "john wick", "With the price on his head ever increasing, legendary hit man John Wick takes his fight against the High Table global as he seeks out the most powerful players in the underworld, from New York to Paris to Japan to Berlin.", "John Wick 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Actors", "Description", "Title" },
                values: new object[] { "john wick", "With the price on his head ever increasing, legendary hit man John Wick takes his fight against the High Table global as he seeks out the most powerful players in the underworld, from New York to Paris to Japan to Berlin.", "John Wick 4" });
        }
    }
}
