using PokemonWebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonWebapp.ViewModels.HuntViewModel
{
    public class HuntViewModel
    {
        public User User { get; set; } = new User();
        public Pokemon Pokemon { get; set; } = new Pokemon();
        public Fight Fight { get; set; } = new Fight();
    }
}
