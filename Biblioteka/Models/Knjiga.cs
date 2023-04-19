namespace Biblioteka.Models
{
    public class Knjiga
    {
        public int Id { get; set; }
        public string Naziv { get; set; } = null!;
        public string Autor { get; set; } = null!;
        public int ClanId { get; set; }
        public Clan Clan { get; set; } = null!;
    }
}
