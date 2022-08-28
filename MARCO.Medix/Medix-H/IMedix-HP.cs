using MARCO.Medix.Grpc;
using MARCO.Medix.Medix_H.Dtos;
using MARCO.Medix.Medix_H.Dtos.Request;
using MARCO.Medix.Medix_H.Dtos.Response;
using Microsoft.AspNetCore.Http;
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
        [OperationContract]
        public IHCodeResponse GetHCode(IHCodeRequest codeRequest);
        /// <summary>
        /// query can be a regex expression
        /// </summary>
        /// <param name="query">
        /// query can be a regex expression
        /// 
        /// </param>
        /// <returns>
        ///  list of Physicians
        /// 
        /// </returns>
        [OperationContract]
        public IAsyncEnumerable<IPhysician> GetPhysicians(string query);
    }
 
}
