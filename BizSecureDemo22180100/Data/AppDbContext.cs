using Microsoft.EntityFrameworkCore;
using BizSecureDemo22180100.Models;



namespace BizSecureDemo22180100.Data
{
   
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> Users => Set<AppUser>();
        public DbSet<Order> Orders => Set<Order>();
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }


}
