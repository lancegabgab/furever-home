using FureverHome.Data;
using FureverHome.Models;

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
            var pet = _context.Pets.Find(id);
            return pet;
        }
    }
}
