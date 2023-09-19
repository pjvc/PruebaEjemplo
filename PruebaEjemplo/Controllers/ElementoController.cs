using Microsoft.AspNetCore.Mvc;

namespace PruebaEjemplo.Controllers
{
    public class ElementoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
