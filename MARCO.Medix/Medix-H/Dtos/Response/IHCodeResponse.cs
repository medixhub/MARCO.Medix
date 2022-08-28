using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MARCO.Medix.Grpc.Dtos;

namespace MARCO.Medix.Medix_H.Dtos.Response
{
    public interface IHCodeResponse : IBaseResponse
    {
        [DataMember]
        public string HCode { get; set; }
    }
}
