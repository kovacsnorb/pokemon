using Microsoft.AspNetCore.Mvc;

namespace PokemonWebapp.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
