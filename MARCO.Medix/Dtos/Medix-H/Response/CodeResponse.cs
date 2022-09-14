using MARCO.Medix.Dtos.Medix_H.Response;
using System.Runtime.Serialization;

namespace MARCO.Medix.Dtos.Medix_H.Response
{
    [DataContract]
    public class CodeResponse : ICodeResponse
    {
        [DataMember]     
        public string Code { get; set; }

    }
}
