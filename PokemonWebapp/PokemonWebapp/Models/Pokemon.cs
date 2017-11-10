﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonWebapp.Models
{
    public class Pokemon
    {
        public int PokemonId { get; set; }
        public PokemonType Type { get; set; }
        public int Level { get; set; }
    }
}
