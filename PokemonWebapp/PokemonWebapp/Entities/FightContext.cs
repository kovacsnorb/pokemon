using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonWebapp.Models;

namespace PokemonWebapp.Entities
{
    public class FightContext : DbContext
    {
        public FightContext(DbContextOptions<FightContext> options) : base(options)
        {
        }

        public DbSet<Fight> Fights { get; set; }

    }
}
