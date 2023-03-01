using InventoryManagementSystem.Models.Account;
using Microsoft.EntityFrameworkCore;
namespace InventoryManagementSystem.Data
{
    public class ApplicationContext : DbContext 
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options): base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
