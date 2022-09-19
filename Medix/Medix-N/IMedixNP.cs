using Medix.Dtos;
using Medix.Dtos.Medix_N.Request;

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Medix.Medix_N
{
    [ServiceContract]
    public interface IMedixNP
    {
        [OperationContract]
        public BaseResponse DownloadStudy(DownloadStudyRequest downloadStudyRequest);

    }
}
