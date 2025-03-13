using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    public class HomeController : Controller
    {
        public string MSNTexto()
        {
            return "Mensaje de ejecución desde Homecontroller en Visual Studio";
        }
    }
}
