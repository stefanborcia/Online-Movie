using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_MVC.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
