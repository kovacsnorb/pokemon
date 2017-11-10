using Microsoft.AspNetCore.Mvc;
using PokemonWebapp.ViewModels.HuntViewModel;

namespace PokemonWebapp.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login(HuntViewModel huntViewModelFromForm)
        {
            return View(huntViewModelFromForm);
        }
    }
}
