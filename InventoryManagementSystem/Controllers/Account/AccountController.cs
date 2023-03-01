using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers.Account
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SignUp()   //GET method
        {
            return View();
        }
    }
}
