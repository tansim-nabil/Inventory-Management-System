using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models.Account;
using InventoryManagementSystem.Models.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly ApplicationContext context;

        public AccountController(ApplicationContext context)
        {
            this.context = context;
        }
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
        public IActionResult SignUp(SignUpUserViewModel model)
        {
            if(ModelState.IsValid)
            {
                var data = new User()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Password = model.Password,
                    PhoneNumber = model.PhoneNumber
                };
                context.Users.Add(data);
                context.SaveChanges();
                TempData["successMessage"] = "You are eligible now";
                return RedirectToAction("Login");
            }
            else
            {

                return View(model);
            }

        }
    }
}
