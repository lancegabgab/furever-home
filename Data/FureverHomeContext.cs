using FureverHome.Models;
using Microsoft.EntityFrameworkCore;

namespace furever_home.Data
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
