using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos.Medix_H.Request
{
    public interface IIssueCodeRequest
    {
        [DataMember]
        string MobileNumber { get; set; }
        [DataMember]
        string StudyInstanceUID { get; set; }
        [DataMember]
        string PatientName { get; set; }
        [DataMember]
        string ServerID { get; set; }
        [DataMember]
        string StudyDate { get; set; }
        [DataMember]
        string NodeId { get; set; }
        [DataMember]
        string ReferringPhysicianId { get; set; }
        [DataMember]
        string InstitutionId { get; set; }
        [DataMember]
        string SendTo { get; set; }
        [DataMember]
        bool IssueImmediate { get; set; }
        [DataMember]
        string NationalID { get; set; }
        [DataMember]
        string PatientID { get; set; }
        [DataMember]
        string LocalPatientName { get; set; }
    }
}
