using Microsoft.AspNetCore.Mvc;
using NahodneCislo.Models;

namespace NahodneCislo.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            Generator generator = new Generator();
            ViewBag.Cislo = generator.VratCislo();
            return View();
        }
    }
}
