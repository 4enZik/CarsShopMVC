using CarsShop.App_Data;
using Microsoft.AspNetCore.Mvc;
using CarsShop.Models;
using System.Diagnostics.Eventing.Reader;

namespace CarsShop.Controllers
{
	public class HomeController : Controller
    {
        AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
		}

        [HttpPost]
        public IActionResult Login([FromForm]Models.AccountLogin account)
        {
            if(account.Login == "4enZik" && account.Password == "123456789")
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }

    }
}
