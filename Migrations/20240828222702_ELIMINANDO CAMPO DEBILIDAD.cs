using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POKEMONPRUEBA.Migrations
{
    /// <inheritdoc />
    public partial class ELIMINANDOCAMPODEBILIDAD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Debilidad",
                table: "Pokemons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Debilidad",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
