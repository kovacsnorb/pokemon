using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonWebapp.Models;
using PokemonWebapp.ViewModels.HuntViewModel;

namespace PokemonWebapp.Controllers
{
    [Route("/user")]
    public class UserController : Controller
    {
        Random random = new Random();
        //User user;
        HuntViewModel huntViewModel;
     

        public UserController(HuntViewModel huntViewModel)
        {
            this.huntViewModel = huntViewModel;
        }

        [HttpPost]
        public IActionResult LoginHandler(HuntViewModel huntViewModelFromForm)
        {
            huntViewModel.User.Name = huntViewModelFromForm.User.Name;

            if (huntViewModel.User.Pokemons.Count != 0)
            {
                huntViewModel.User.Pokemons.RemoveRange(0, huntViewModel.User.Pokemons.Count);
            }
            huntViewModel.User.Pokemons.Add(new Pokemon() { Id = huntViewModel.User.Pokemons.Count + 1, Level = random.Next(1, 6), Type = (PokemonType)random.Next(1, 22) });
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
                Id = huntViewModel.User.Pokemons.Count + 1,
                Level = random.Next(1, 6),
                Type = (PokemonType)random.Next(1, 22)
            };
            huntViewModel.Pokemon = pokemon;
            return View(huntViewModel);
        }

        [HttpPost]
        [Route("/user/catch")]
        public IActionResult Catch(Pokemon pokemonFromForm)
        {
            huntViewModel.User.Pokemons.Add(pokemonFromForm);
            return LocalRedirect("/user/" + huntViewModel.User.ReplaceAscii());
        }

        [HttpPost]
        [Route("/user/remove")]
        public IActionResult Remove(Pokemon pokemonFromForm)
        {
            huntViewModel.User.Pokemons.RemoveAll(m => m.Id == pokemonFromForm.Id);
            return LocalRedirect("/user/" + huntViewModel.User.ReplaceAscii());
        }
    }
}
