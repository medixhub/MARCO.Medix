using AutoMapper;
using Medix.Common.Demo;
using Medix.Common.Demo.Data;
using Medix.Common.Demo.Models;
using Medix.Dtos;
using Medix.Dtos.Medix_H.Request;
using Medix.Dtos.Medix_H.Response;
using Medix.Medix_H;
using Microsoft.AspNetCore.Mvc;
using Physician = Medix.Dtos.Physician;

namespace Medix.WebApi.Demo.Controllers
{
    [ApiController]
    [Route("api/[controller]/[Action]")]
    public class MedixHPController : ControllerBase,IMedixHP
    {
        

        private readonly ILogger<MedixHPController> _logger;
        public MedixDbContext MedixDbContext { get; }
        public IMapper Mapper { get; }
        public MedixHPController(ILogger<MedixHPController> logger, MedixDbContext medixDbContext, IMapper mapper)
        {
            MedixDbContext = medixDbContext;
            Mapper = mapper;
            _logger = logger;
        }

        [HttpPost(Name = "GetIssuedCodes")]
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
        [HttpPost(Name = "GetPhysicians")]
        public IEnumerable<Physician> GetPhysicians([FromBody]string query)
        {
            var physicians = MedixDbContext.Physicians.ToList();
            var response = Mapper.Map<List<Dtos.Physician>>(physicians);

            return response;
        }
        [HttpPost(Name = "IssueCode")]
        public IssueCodeResponse IssueCode(IssueCodeRequest codeRequest)
        {
            var study = Mapper.Map<Common.Demo.Models.Study>(codeRequest);

            MedixDbContext.Studies.Add(study);


            var code = GenerateCode.Code();
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
    }
}