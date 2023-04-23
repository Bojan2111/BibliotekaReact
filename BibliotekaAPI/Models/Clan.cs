using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace BibliotekaAPI.Models
{
    public class Clan
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Ime { get; set; } = null!;
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Prezime { get; set; } = null!;
    }
}
