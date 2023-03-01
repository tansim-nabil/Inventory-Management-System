﻿using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models.Account
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
