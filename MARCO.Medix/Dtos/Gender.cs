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
        [EnumMember]
        Male = 0,
        [EnumMember]
        Female = 1,
        [EnumMember]
        Other = 2,
    }
}
