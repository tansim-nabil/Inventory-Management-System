using InventoryManagementSystem.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSystem.Controllers.Account
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginSignUpViewModel model)
        {
            return View();
        }
        public IActionResult SignUp()   //GET method
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(LoginSignUpViewModel model)
        {
            return View();
        }
    }
}
