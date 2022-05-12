using GB_WebAppCource.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GB_WebAppCource.DAL.Repository.Database
{
    public sealed class Context : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }

    
}
