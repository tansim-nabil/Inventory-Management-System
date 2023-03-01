namespace InventoryManagementSystem.Models.ViewModel
{
    public class LoginSignUpViewModel
    {
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
