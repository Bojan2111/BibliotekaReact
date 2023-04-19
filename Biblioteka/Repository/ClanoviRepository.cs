using Biblioteka.Models;
using Biblioteka.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Repository
{
    public class ClanoviRepository : IClanoviRepository
    {
        public readonly AppDbContext _context;
        public ClanoviRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Clan clan)
        {
            _context.Add(clan);
            _context.SaveChanges();
        }

        public IQueryable<Clan> GetAll()
        {
            return _context.Clanovi;
        }

        public Clan GetById(int id)
        {
            return _context.Clanovi.FirstOrDefault(clan => clan.Id == id);
        }

        public void Update(Clan clan)
        {
            _context.Entry(clan).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Delete(Clan clan)
        {
            _context.Clanovi.Remove(clan);
            _context.SaveChanges();
        }
    }
}
