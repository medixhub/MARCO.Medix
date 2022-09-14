using MARCO.Medix.Dtos;
using MARCO.Medix.Dtos.Medix_H.Request;
using MARCO.Medix.Dtos.Medix_H.Response;
using MARCO.Medix.Grpc;
using MARCO.Medix.Medix_H;
using MARCO.Medix.UI.Data;


namespace MARCO.Medix.UI.Services
{
    public class MedixHP : IMedixHP, IGrpcService
    {
        //public MedixHP(MedixDbContext medixDbContext, IHttpContextAccessor httpContextAccessor)
        //{
        //    MedixDbContext = medixDbContext;
        //    HttpContextAccessor = httpContextAccessor;
        //}

        public IHttpContextAccessor HttpContextAccessor { get; set; }
        public MedixDbContext MedixDbContext { get; }
        public CodeResponse IssueCode(IssueCodeRequest codeRequest)
        {

            return new CodeResponse() { Code = "sample" };

        }

        public IEnumerable<IssueCodeRequest> GetIssuedCodes(GetIssuedCodesRequest request)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Physician> GetPhysicians(string query)
        {
            throw new NotImplementedException();
        }

     
            
    }
}
