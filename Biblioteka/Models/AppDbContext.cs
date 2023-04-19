using Biblioteka.Models.Login;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biblioteka.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Clan> Clanovi { get; set; }
        public DbSet<Knjiga> Knjige { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Clan>().HasData(
                new Clan()
                {
                    Id = 1,
                    Ime = "Pera",
                    Prezime = "Peric"
                },
                new Clan()
                {
                    Id = 2,
                    Ime = "Mitar",
                    Prezime = "Miric"
                },
                new Clan()
                {
                    Id = 3,
                    Ime = "Ana",
                    Prezime = "Ancic"
                }
            );

            builder.Entity<Knjiga>().HasData(
                new Knjiga()
                {
                    Id = 1,
                    Naziv = "Dervis i smrt",
                    Autor = "Mesa Selimovic",
                    ClanId = 2
                },
                new Knjiga()
                {
                    Id = 2,
                    Naziv = "Na Drini cuprija",
                    Autor = "Ivo Andric",
                    ClanId = 3
                },
                new Knjiga()
                {
                    Id = 3,
                    Naziv = "Bozanstvena komedija",
                    Autor = "Dante Aligijeri",
                    ClanId = 1
                },
                new Knjiga()
                {
                    Id = 4,
                    Naziv = "Avanture Serloka Holmsa",
                    Autor = "Sir Artur Konan Dojl",
                    ClanId = 3
                },
                new Knjiga()
                {
                    Id = 5,
                    Naziv = "Dozivljaji Nikoletine Bursaca",
                    Autor = "Branko Copic",
                    ClanId = 1
                }
            );

            base.OnModelCreating(builder);
        }
    }
}
