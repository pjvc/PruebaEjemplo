using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace PruebaEjemplo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
