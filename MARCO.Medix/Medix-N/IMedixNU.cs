using MARCO.Medix.Dtos;
using MARCO.Medix.Dtos.Medix_N.Request;
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
