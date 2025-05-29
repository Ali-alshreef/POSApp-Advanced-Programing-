using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using POSApp.Models;

namespace POSApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
