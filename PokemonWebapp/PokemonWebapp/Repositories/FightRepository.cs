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

        public List<Fight> GetAllFights()
        {
            return FightContext.Fights.Where(t => t.Player.Length != 0).ToList();
        }

        public List<Fight> GetUserFights(string name)
        {
            return FightContext.Fights.Where(t => t.Player == name).ToList();
        }
    }
}
