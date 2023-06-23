using CVManagementWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CVManagementWebApp.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<CV> CV { get; set; }

    }
}
