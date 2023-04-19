namespace Biblioteka.Models
{
    public class Knjiga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Autor { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
    }
}
