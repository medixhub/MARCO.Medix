using MARCO.Medix.Dtos;
using MARCO.Medix.Dtos.Medix_N.Request;
using MARCO.Medix.Grpc;
using MARCO.Medix.Medix_N;

namespace MARCO.Medix.UI.Services
{
    public class MedixNP : IMedixNP, IGrpcService
    {
        public IHttpContextAccessor HttpContextAccessor => throw new NotImplementedException();

        public BaseResponse DownloadStudy(DownloadStudyRequest downloadStudyRequest)
        {
            throw new NotImplementedException();
        }
 
    }
}
