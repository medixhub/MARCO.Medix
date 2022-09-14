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
        public MedixHP(MedixDbContext medixDbContext)
        {
            MedixDbContext = medixDbContext;

        }

        public IHttpContextAccessor HttpContextAccessor { get; set; }
        public MedixDbContext MedixDbContext { get; }
        public CodeResponse IssueCode(IssueCodeRequest codeRequest)
        {
            var list = MedixDbContext.Physicians.Add(new Models.Physician()
            {
                PhysicianId = "10004",
                Name = "Name 10004",
                Code = "10004",
                Gender = Gender.Male,
                Address = "a1",
                InsertDate = DateTime.Now,
                Phone = "01",
                RefuteDescription = "",
                Specialty = "",



            });

            MedixDbContext.SaveChanges();
            return new CodeResponse() { Code = "sample" };

        }

        public IEnumerable<IssueCodeRequest> GetIssuedCodes(GetIssuedCodesRequest request)
        {
            var list = MedixDbContext.Physicians.ToList();
            throw new NotImplementedException();
        }


        public IEnumerable<Physician> GetPhysicians(string query)
        {
            throw new NotImplementedException();
        }



    }
}
