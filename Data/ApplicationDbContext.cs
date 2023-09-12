namespace UserManagementProject.Data;
using UserManagementProject.Models;
using Microsoft.EntityFrameworkCore;


public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

}
