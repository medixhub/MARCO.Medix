using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MARCO.Medix.Dtos.Medix_H.Response;


namespace MARCO.Medix.Dtos
{
    
    public interface IBaseResponse
    {
        [DataMember]
        ResponseStatus Status { get; set; }
        [DataMember]
        public string Message { get; set; }


    }
}
