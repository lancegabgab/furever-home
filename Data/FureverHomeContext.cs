using FureverHome.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FureverHome.Data
{
    public class FureverHomeContext : IdentityDbContext<User>
    {
        public FureverHomeContext(DbContextOptions<FureverHomeContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
    }
}