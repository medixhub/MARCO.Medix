using AutoMapper;
using Medix.Common.Demo;
using Medix.Common.Demo.Data;
using Medix.Common.Demo.Models;
using Medix.Dtos;
using Medix.Dtos.Medix_H.Request;
using Medix.Dtos.Medix_H.Response;
using Medix.Grpc;
using Medix.Medix_H;
 
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Physician = Medix.Dtos.Physician;

namespace Medix.Grpc.Demo.Services
{
    public class MedixHP : IMedixHP, IGrpcService
    {
        public MedixHP(MedixDbContext medixDbContext, IMapper mapper)
        {
            MedixDbContext = medixDbContext;
            Mapper = mapper;
        }

        public IHttpContextAccessor HttpContextAccessor { get; set; }
        public MedixDbContext MedixDbContext { get; }
        public IMapper Mapper { get; }

        public IssueCodeResponse IssueCode(IssueCodeRequest codeRequest)
        {
            var study = Mapper.Map<Common.Demo.Models.Study>(codeRequest);

            MedixDbContext.Studies.Add(study);


            var code =GenerateCode.Code();
            var issuedCode = new IssueCode()
            {
                Code = code,
                StudyInstanceUID = study.StudyInstanceUID
            };
            MedixDbContext.IssueCodes.Add(issuedCode);
            MedixDbContext.SaveChanges();

            var response = new IssueCodeResponse()
            {
                Code = issuedCode.Code,
                StudyInstanceUID = issuedCode.StudyInstanceUID
            };
            return response;

        }

        public IEnumerable<IssueCodeResponse> GetIssuedCodes(GetIssuedCodesRequest request)
        {
            var codes = MedixDbContext.IssueCodes.Where(u => u.StudyInstanceUID == request.StudyInstanceUID).ToList();
            if (!codes.Any())
            {
                return null;
            }
            return codes.Select(u =>
            {
                return new IssueCodeResponse()
                {
                    StudyInstanceUID = u.StudyInstanceUID,
                    Code = u.Code
                };
            });
        }


        public IEnumerable<Physician> GetPhysicians(string query)
        {
            var physicians = MedixDbContext.Physicians.ToList();
            var response = Mapper.Map<List<Dtos.Physician>>(physicians);

            return response;
        }



    }
}
