using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
