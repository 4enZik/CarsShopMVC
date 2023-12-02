using Microsoft.AspNetCore.Mvc;

namespace CarsShop.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
