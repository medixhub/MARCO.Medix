 
using AutoMapper;
 


namespace MARCO.Medix.UI.Utils
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Dtos.Physician,Models.Physician>().ReverseMap();
            
 
        }

    }
}
