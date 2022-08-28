using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_H.Dtos.Response
{
    public enum ResponseStatus
    {
        [DataMember]
        Failed =0,
        [DataMember]
        Success =1

    }
}
