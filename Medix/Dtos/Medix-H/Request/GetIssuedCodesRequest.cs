using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Medix.Dtos.Medix_H.Request
{
    [DataContract]
    public class GetIssuedCodesRequest : IGetIssuedCodesRequest
    {
        [DataMember]
        public string StudyInstanceUID { get; set; }
    }
}
