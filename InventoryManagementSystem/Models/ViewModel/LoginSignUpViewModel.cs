using Microsoft.Build.Framework;

namespace InventoryManagementSystem.Models.ViewModel
{
    public class LoginSignUpViewModel
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
    
    }
}
