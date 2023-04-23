namespace BibliotekaAPI.Models.Dtos
{
    public class KnjigaDTO
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = null!;
        public string Autor { get; set; } = null!;
        public string ClanIme { get; set; } = null!;
        public string ClanPrezime { get; set; } = null!;
    }
}
