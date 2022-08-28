using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MARCO.Medix.Medix_H.Dtos.Response;

namespace MARCO.Medix.Grpc.Dtos
{
    
    public interface IBaseResponse
    {
        [DataMember]
        ResponseStatus Status { get; set; }
        [DataMember]
        public string Message { get; set; }


    }
}
