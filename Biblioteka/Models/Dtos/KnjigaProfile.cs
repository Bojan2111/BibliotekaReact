using AutoMapper;

namespace Biblioteka.Models.Dtos
{
    public class KnjigaProfile : Profile
    {
        public KnjigaProfile()
        {
            CreateMap<Knjiga, KnjigaDTO>();
        }
    }
}
