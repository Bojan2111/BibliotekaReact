using BibliotekaAPI.Models;

namespace BibliotekaAPI.Repository.Interfaces
{
    public interface IKnjigeRepository
    {
        void Add(Knjiga knjiga);
        IQueryable<Knjiga> GetAll();
        Knjiga GetById(int id);
        void Update(Knjiga knjiga);
        void Delete(Knjiga knjiga);
    }
}
