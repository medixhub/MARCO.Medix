
using AutoMapper;
namespace Medix.Grpc.Demo.Utils
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Dtos.Physician, Models.Physician>().ReverseMap();
            CreateMap<Dtos.Medix_H.Request.IssueCodeRequest, Models.Study>();
            CreateMap<Dtos.Medix_H.Response.IssueCodeResponse, Models.IssueCode>();
            


        }

    }
}
