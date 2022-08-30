using MARCO.Medix.Medix_H;
using MARCO.Medix.Medix_H.Dtos;
using MARCO.Medix.Medix_H.Dtos.Request;
using MARCO.Medix.Medix_H.Dtos.Response;

namespace MARCO.Medix.UI.Services
{
    public class MedixHP : IMedixHP
    {
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public IHCodeResponse GetHCode(IHCodeRequest codeRequest)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<IPhysician> GetPhysicians(string query)
        {
            throw new NotImplementedException();
        }
    }
}
