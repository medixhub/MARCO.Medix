using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
 

namespace MARCO.Medix.Dtos.Medix_H.Response
{
    public interface IHCodeResponse : IBaseResponse
    {
        [DataMember]
        public string Code { get; set; }
    }
}
