using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POKEMONPRUEBA.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    IdPokemon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ps = table.Column<int>(type: "int", nullable: false),
                    Atq = table.Column<int>(type: "int", nullable: false),
                    Def = table.Column<int>(type: "int", nullable: false),
                    AtqEs = table.Column<int>(type: "int", nullable: false),
                    DefEs = table.Column<int>(type: "int", nullable: false),
                    Velo = table.Column<int>(type: "int", nullable: false),
                    Debilidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.IdPokemon);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
