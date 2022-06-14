using Microsoft.AspNetCore.Mvc;

namespace ProductsUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
