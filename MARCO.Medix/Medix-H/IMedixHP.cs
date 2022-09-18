using MARCO.Medix.Dtos;
using MARCO.Medix.Dtos.Medix_H.Request;
using MARCO.Medix.Dtos.Medix_H.Response;
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
    public interface IMedixHP 
    {
        [OperationContract]
        public IssueCodeResponse IssueCode(IssueCodeRequest codeRequest);
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
        public IEnumerable<Physician> GetPhysicians(string query);
        [OperationContract]
        public IEnumerable<IssueCodeResponse> GetIssuedCodes(GetIssuedCodesRequest request);
    }
 
}
