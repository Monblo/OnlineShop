using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
