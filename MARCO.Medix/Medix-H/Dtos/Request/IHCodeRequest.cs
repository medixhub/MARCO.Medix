using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_H.Dtos.Request
{
    public interface IHCodeRequest
    {
        // string Modality { get; set; }
        //  string PatientSex { get; set; }
        //  string BodyPartExamined { get; set; }
        //  string StudyDesc { get; set; }
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

    }
}
