namespace BibliotekaAPI.Models.Dtos
{
    public class KnjigeKodClanaDTO
    {
        public string? ClanIme { get; set; }
        public string? ClanPrezime { get; set; }
        public IEnumerable<Knjiga>? KnjigeKodClana { get; set; }
    }
}
