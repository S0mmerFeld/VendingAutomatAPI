using AutoMapper;
namespace AutomatAPI.Models
{
    public class AutomatMachineProfile : Profile
    {
        public AutomatMachineProfile()
        {
            CreateMap<AutomatMachine, AutomatMachineDTO>();
            CreateMap<AutomatMachineDTO, AutomatMachine>();
        }            
    }
}
