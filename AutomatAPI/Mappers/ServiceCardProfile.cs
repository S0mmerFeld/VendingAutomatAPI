using AutoMapper;
namespace AutomatAPI.Models
{
    public class ServiceCardProfile : Profile
    {
        public ServiceCardProfile()
        {
            CreateMap<ServiceCard, ServiceCardDTO>();
            CreateMap<ServiceCardDTO, ServiceCard>();

        }            
    }
}
