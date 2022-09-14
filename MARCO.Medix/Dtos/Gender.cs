using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos
{
    [DataContract]
    public enum Gender
    {
        [DataMember]
        Male = 0,
        [DataMember]
        Female = 1,
        [DataMember]
        Other = 2,
    }
}
