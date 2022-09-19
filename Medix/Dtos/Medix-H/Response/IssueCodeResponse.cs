using Medix.Dtos.Medix_H.Response;
using System.Runtime.Serialization;

namespace Medix.Dtos.Medix_H.Response
{
    [DataContract]
    public class IssueCodeResponse : IIssueCodeResponse
    {
        [DataMember]     
        public string Code { get; set; }
        [DataMember]
        public string StudyInstanceUID { get; set; }

    }
}
