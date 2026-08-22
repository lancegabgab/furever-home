using FureverHome.Data;
using FureverHome.Enums;
using FureverHome.Models;
using Microsoft.EntityFrameworkCore;

namespace FureverHome.Services
{
    public class PetService
    {
        private readonly FureverHomeContext _context;

        public PetService(FureverHomeContext context)
        {
            _context = context;
        }

        public List<Pet> GetAll(string? search = null, PetType? petType = null, PetGender? petGender = null)
        {
            var query = _context.Pets
                .Where(p => p.Status == PetStatus.Available)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(p => p.Name.Contains(search));
            }

            if (petType.HasValue)
            {
                query = query.Where(p => p.PetType == petType.Value);
            }

            if (petGender.HasValue)
            {
                query = query.Where(p => p.Gender == petGender.Value);
            }

            return query.ToList();
        }

        public Pet? GetById(Guid id)
        {
            var pet = _context.Pets
                .Include(p => p.Shelter)
                .FirstOrDefault(p => p.Id == id);
            return pet;
        }
    }
}
