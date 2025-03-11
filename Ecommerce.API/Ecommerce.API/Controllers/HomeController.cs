using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    public class HomeController : Controller
    {
        public string MSNTexto()
        {
            return "Hello World desde la nueva funcionalidad";
        }
    }
}
