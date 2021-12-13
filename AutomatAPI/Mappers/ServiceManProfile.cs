using AutoMapper;
namespace AutomatAPI.Models
{
    public class ServiceManProfile : Profile
    {
        public ServiceManProfile()
        {
            CreateMap<ServiceMan, ServiceManDTO>().ForMember(prop => prop.SMCard, prop => prop.Ignore()); ;
            CreateMap<ServiceManDTO, ServiceMan>();

        }            
    }
}
