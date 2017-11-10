using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonWebapp.Models
{
    public class Fight
    {
        public int Id { get; set; }
        public string Player { get; set; }
        public string PlayerPokemon { get; set; }
        public int PlayerPokemonLevel { get; set; }
        public int PlayerPokemonId { get; set; }
        public int PlayerPokemonLuckyNumber { get; set; }
        public int PlayerFightPoint { get; set; }
        public string ComputerPokemon { get; set; }
        public int ComputerPokemonLevel { get; set; }
        public int ComputerPokemonId { get; set; }
        public int ComputerPokemonLuckyNumber { get; set; }
        public int ComputerFightPoint { get; set; }
    }
}
