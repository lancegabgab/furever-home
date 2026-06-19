using furever_home.Data;
using FureverHome.Models;

namespace FureverHome.Services
{
    public class ShelterService
    {
        private readonly FureverHomeContext _context;

        public ShelterService(FureverHomeContext context)
        {
            _context = context;
        }

        public List<Shelter> GetAll()
        {
            var shelters = _context.Shelters.ToList();
            return shelters;
        }

        public Shelter? GetById(int id)
        {
            var shelter = _context.Shelters.Find(id);
            return shelter;
        }

        public void Create(Shelter shelter)
        {
            _context.Shelters.Add(shelter);
            _context.SaveChanges();
        }

        public void Update(Shelter shelter)
        {
            _context.Shelters.Update(shelter);
            _context.SaveChanges();
        }

    }
}
