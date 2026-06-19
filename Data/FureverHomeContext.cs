using FureverHome.Models;
using Microsoft.EntityFrameworkCore;

namespace FureverHome.Data
{
    public class FureverHomeContext : DbContext
    {
        public FureverHomeContext(DbContextOptions<FureverHomeContext> options)
        : base(options)
        {
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
    }
}
