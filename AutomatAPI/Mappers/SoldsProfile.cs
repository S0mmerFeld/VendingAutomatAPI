using AutoMapper;
namespace AutomatAPI.Models
{
    public class SoldsProfile : Profile
    {
        public SoldsProfile()
        {
            CreateMap<Solds, SoldsDTO>();
            CreateMap<SoldsDTO, Solds>();
        


        }            
    }
}
