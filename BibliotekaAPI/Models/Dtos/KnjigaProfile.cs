using AutoMapper;

namespace BibliotekaAPI.Models.Dtos
{
    public class KnjigaProfile : Profile
    {
        public KnjigaProfile()
        {
            CreateMap<Knjiga, KnjigaDTO>();
            CreateMap<Clan, KnjigaDTO>();
        }
    }
}
