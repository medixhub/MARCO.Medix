using MARCO.Medix.Grpc.Dtos;
using MARCO.Medix.Medix_N.Dtos.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_N
{
    public interface IMedixNU
    {
        public IBaseResponse DownloadStudy(IDownloadStudyRequest downloadStudyRequest);
    }
}
