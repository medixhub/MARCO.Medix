using Medix.Dtos;
using Medix.Dtos.Medix_N.Request;
using Medix.Grpc;
using Medix.Medix_N;

namespace Medix.UI.Services
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
