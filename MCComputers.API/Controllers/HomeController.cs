using Microsoft.AspNetCore.Mvc;

namespace MCComputers.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
