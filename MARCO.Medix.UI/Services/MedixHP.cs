using MARCO.Medix.Dtos.Medix_H;
using MARCO.Medix.Dtos.Medix_H.Request;
using MARCO.Medix.Dtos.Medix_H.Response;
using MARCO.Medix.Grpc;
using MARCO.Medix.Medix_H;
using MARCO.Medix.UI.Data;

namespace MARCO.Medix.UI.Services
{
    public class MedixHP : IMedixHP, IGrpcService
    {
        //public MedixHP(MedixDbContext medixDbContext,IHttpContextAccessor httpContextAccessor)
        //{
        //    MedixDbContext = medixDbContext;
        //    HttpContextAccessor = httpContextAccessor;
        //}

        public IHttpContextAccessor HttpContextAccessor { get; set; }
        public MedixDbContext MedixDbContext { get; }

        public IAsyncEnumerable<IIssueCodeRequest> GetIssuedCodes(IGetIssuedCodesRequest request)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<IPhysician> GetPhysicians(string query)
        {
            var d = MedixDbContext.Physicians.ToList();
            throw new NotImplementedException();
        }

        public ICodeResponse IssueCode(IIssueCodeRequest codeRequest)
        {
     
            throw new NotImplementedException();
        }

        IAsyncEnumerable<IPhysician> IMedixHP.GetPhysicians(string query)
        {
            throw new NotImplementedException();
        }
    }
}
