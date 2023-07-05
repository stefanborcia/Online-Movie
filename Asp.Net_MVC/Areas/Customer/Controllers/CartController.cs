using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_MVC.Areas.Customer.Controllers
{
    public class CartController : Controller
    {
        [Area("customer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
