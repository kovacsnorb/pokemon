using PokemonWebapp.Entities;
using PokemonWebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonWebapp.Repositories
{
    public class FightRepository
    {
        FightContext FightContext;

        public FightRepository(FightContext fightContext)
        {
            FightContext = fightContext;
        }

        public void AddFight(Fight myFight)
        {
            FightContext.Fights.Add(myFight);
            FightContext.SaveChanges();
        }
    }
}
