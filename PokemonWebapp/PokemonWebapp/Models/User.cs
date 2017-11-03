using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PokemonWebapp.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public User()
        {
            Pokemons = new List<Pokemon>();
        }

        public string ReplaceAscii()
        {
            return Regex.Replace(Name, @"[^\u0000-\u007F]+", string.Empty);
        }
        
    }
}
