using MARCO.Medix.Dtos;
using MARCO.Medix.Dtos.Medix_N.Request;
using MARCO.Medix.Grpc;
using MARCO.Medix.Medix_N;

namespace MARCO.Medix.UI.Services
{
    public class MedixNP : IMedixNP , IGrpcService
    {
        public IHttpContextAccessor HttpContextAccessor => throw new NotImplementedException();

        IBaseResponse IMedixNP.DownloadStudy(IDownloadStudyRequest downloadStudyRequest)
        {
            throw new NotImplementedException();
        }
    }
}
