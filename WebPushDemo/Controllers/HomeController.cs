using Microsoft.AspNetCore.Mvc;

namespace ServiceWorkerDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
