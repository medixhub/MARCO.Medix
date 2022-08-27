using MARCO.Medix.Grpc;
using MARCO.Medix.Medix_H.Dtos.Request;
using MARCO.Medix.Medix_H.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_H
{
    [ServiceContract]
    public interface IMedix_HP : IGrpcService
    {

        public IHCodeResponse GetHCode(IHCodeRequest codeRequest);
    }
}
