using MARCO.Medix.Grpc;
using MARCO.Medix.Grpc.Dtos;
using MARCO.Medix.Medix_N.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_N
{
    [ServiceContract]
    public interface IMedixNP:IGrpcService
    {
        [OperationContract]
        public IBaseResponse DownloadStudy(IDownloadStudyRequest downloadStudyRequest);

    }
}
