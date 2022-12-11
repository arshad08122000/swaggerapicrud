using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class ContactAPIDbContext : DbContext
    {
        public ContactAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        

        public DbSet<Contact> contacts { get; set; }
    }
}
