using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos.Medix_H.Request
{
    public class IssueCodeRequest : IIssueCodeRequest
    {
        [DataMember]
        public string MobileNumber { get; set; }
        [DataMember]
        public string StudyInstanceUID { get; set; }
        [DataMember]
        public string PatientName { get; set; }
        [DataMember]
        public string ServerID { get; set; }
        [DataMember]
        public string StudyDate { get; set; }
        [DataMember]
        public string NodeId { get; set; }
        [DataMember]
        public string ReferringPhysicianId { get; set; }
        [DataMember]
        public string InstitutionId { get; set; }
        [DataMember]
        public string SendTo { get; set; }
        [DataMember]
        public bool IssueImmediate { get; set; }
        [DataMember]
        public string NationalID { get; set; }
        [DataMember]
        public string PatientID { get; set; }
        [DataMember]
        public string LocalPatientName { get; set; }
    }
}
