using MARCO.Medix.Grpc.Dtos;
using MARCO.Medix.Medix_N;
using MARCO.Medix.Medix_N.Dtos.Request;

namespace MARCO.Medix.UI.Services
{
    public class MedixNP : IMedixNP 
    {
        public IHttpContextAccessor HttpContextAccessor => throw new NotImplementedException();

        public IBaseResponse DownloadStudy(IDownloadStudyRequest downloadStudyRequest)
        {
            throw new NotImplementedException();
        }
    }
}
