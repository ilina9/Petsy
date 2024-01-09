using Microsoft.AspNetCore.Mvc;

namespace Petsy.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
