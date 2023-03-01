using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models.Account;
using InventoryManagementSystem.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

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
            if (ModelState.IsValid)
            {
                var data = context.Users.Where (e => e.UserName == model.UserName).SingleOrDefault();
                if (data != null)
                {
                    bool IsValid = (data.UserName == model.UserName && data.Password == model.Password);
                    if (IsValid)
                    {
                        var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, model.UserName) },
                            CookieAuthenticationDefaults.AuthenticationScheme);
                        var principal = new ClaimsPrincipal(identity);
                        HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                        HttpContext.Session.SetString("Username", model.UserName);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["errorMessage"] = "Incorrect Password";
                        return View(model);
                    }
                }
                else
                {
                    TempData["errorMessage"] = "Username not found";
                    return View(model);
                }
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
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
