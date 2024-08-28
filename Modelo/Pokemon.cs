using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POKEMONPRUEBA.Modelo
{
    public class Pokemon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPokemon { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Ps { get; set; }
        public int Atq { get; set; }
        public int Def { get; set; }
        public int AtqEs { get; set; }
        public int DefEs{ get; set; }
        public int Velo { get; set; }

        public int Debilidad { get; set; }
    }
}
