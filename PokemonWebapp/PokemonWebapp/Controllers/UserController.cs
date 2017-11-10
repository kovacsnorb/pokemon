using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonWebapp.Models;
using PokemonWebapp.ViewModels.HuntViewModel;
using PokemonWebapp.Repositories;

namespace PokemonWebapp.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        FightRepository FightRepository;

        Random random = new Random();
        HuntViewModel huntViewModel;

        public UserController(HuntViewModel huntViewModel, FightRepository fightRepository)
        {
            this.huntViewModel = huntViewModel;
            FightRepository = fightRepository;
        }

        [HttpPost]
        public IActionResult LoginHandler(HuntViewModel huntViewModelFromForm)
        {
            huntViewModel.User.Name = huntViewModelFromForm.User.Name;

            if (huntViewModel.User.Pokemons.Count != 0)
            {
                huntViewModel.User.Pokemons.RemoveRange(0, huntViewModel.User.Pokemons.Count);
            }
            huntViewModel.User.Pokemons.Add(new Pokemon()
            {
                PokemonId = huntViewModel.User.Pokemons.Count + 1,
                Level = random.Next(1, 6),
                Type = (PokemonType)random.Next(1, 22)
            });
            return LocalRedirect("/user/" + huntViewModel.User.ReplaceAscii());
        }

        [HttpGet]
        [Route("/user/{0}")]
        public IActionResult Profile()
        {
            return View(huntViewModel);
        }

        [HttpGet]
        [Route("/user/hunt")]
        public IActionResult Hunt()
        {
            var pokemon = new Pokemon()
            {
                PokemonId = huntViewModel.User.Pokemons.Count + 1,
                Level = random.Next(1, 6),
                Type = (PokemonType)random.Next(1, 22)
            };
            huntViewModel.Pokemon = pokemon;
            return View(huntViewModel);
        }

        [HttpPost]
        [Route("/user/catch")]
        public IActionResult Catch(Pokemon pokemonFromForm, Fight fightFromForm)
        {
            huntViewModel.User.Pokemons.Add(pokemonFromForm);
            FightRepository.AddFight(fightFromForm);
            return LocalRedirect("/user/" + huntViewModel.User.ReplaceAscii());
        }

        [HttpPost]
        [Route("/user/remove")]
        public IActionResult Remove(Pokemon pokemonFromForm, Fight fightFromForm)
        {
            huntViewModel.User.Pokemons.RemoveAll(m => m.PokemonId == pokemonFromForm.PokemonId);
            FightRepository.AddFight(fightFromForm);
            return LocalRedirect("/user/" + huntViewModel.User.ReplaceAscii());
        }

        [HttpGet]
        [Route("/statistics/{name}")]
        public IActionResult Statistics([FromRoute] string Name)
        {
            string name = Name;
            var Fights = FightRepository.GetUserFights(name);
            return View(Fights);
        }

        [HttpGet]
        [Route("/statistics/all")]
        public IActionResult Statistics()
        {
            var Fights = FightRepository.GetAllFights();
            return View(Fights);
        }
    }
}
