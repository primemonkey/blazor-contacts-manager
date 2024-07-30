using Microsoft.EntityFrameworkCore;
using ContactManager.Shared.Models;

namespace ContactManager.Server.Data
{
    public class ApplicationDbContext : DbContext
    {      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet representing the Contacts table in the database
        public DbSet<Contact> Contacts { get; set; }
    }
}