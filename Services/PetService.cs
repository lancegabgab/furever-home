using FureverHome.Data;
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

        public List<Pet> GetAll()
        {
            var pets = _context.Pets.ToList();
            return pets;
        }

        public Pet? GetById(int id)
        {
            var pet = _context.Pets
                .Include(p => p.Shelter)
                .FirstOrDefault(p => p.Id == id);
            return pet;
        }
    }
}
