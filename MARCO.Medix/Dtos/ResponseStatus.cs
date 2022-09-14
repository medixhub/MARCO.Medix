using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos
{
    [DataContract]
    public enum ResponseStatus
    {
        [DataMember]
        Failed = 0,
        [DataMember]
        Success = 1

    }
}
