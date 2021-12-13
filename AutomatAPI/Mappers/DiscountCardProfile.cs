using AutoMapper;
namespace AutomatAPI.Models
{
    public class DiscountCardProfile : Profile
    {
        public DiscountCardProfile()
        {
            CreateMap<DiscountCard, DiscountCardDTO>();
            CreateMap<DiscountCardDTO, DiscountCard>();

        }            
    }
}
