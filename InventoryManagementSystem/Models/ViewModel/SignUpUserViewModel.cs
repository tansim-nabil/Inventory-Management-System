using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;


namespace InventoryManagementSystem.Models.ViewModel
{
    public class SignUpUserViewModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }
        
        public string Email { get; set; }
        
        public long PhoneNumber { get; set; }
        
        public string Password { get; set; }
        
        public string ConfirmPassword { get; set; }
    }
}
