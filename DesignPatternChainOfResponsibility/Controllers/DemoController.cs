using Microsoft.AspNetCore.Mvc;

namespace DesignPatternChainOfResponsibility.Controllers
{
    public class DemoController : Controller
    {
        // Sweat Alert kullanımı...
        public IActionResult Index()
        {
            return View();
        }
    }
}
