using Biblioteka.Models;
using Biblioteka.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Repository
{
    public class KnjigeRepository : IKnjigeRepository
    {
        private readonly AppDbContext _context;
        public KnjigeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Knjiga knjiga)
        {
            _context.Knjige.Add(knjiga);
            _context.SaveChanges();
        }

        public IQueryable<Knjiga> GetAll()
        {
            return _context.Knjige;
        }

        public Knjiga GetById(int id)
        {
            return _context.Knjige.FirstOrDefault(knjiga => knjiga.Id == id);
        }
        public void Update(Knjiga knjiga)
        {
            _context.Entry(knjiga).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public void Delete(Knjiga knjiga)
        {
            _context.Knjige.Remove(knjiga);
            _context.SaveChanges();
        }
    }
}
