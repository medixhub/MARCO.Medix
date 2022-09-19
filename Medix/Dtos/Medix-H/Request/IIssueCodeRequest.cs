using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Medix.Dtos.Medix_H.Request
{
    public interface IIssueCodeRequest
    {
        string MobileNumber { get; set; }
        string StudyInstanceUID { get; set; }
        string PatientName { get; set; }
        string ServerID { get; set; }
        string StudyDate { get; set; }
        string NodeId { get; set; }
        string ReferringPhysicianId { get; set; }
        string InstitutionId { get; set; }
        string SendTo { get; set; }
        bool IssueImmediate { get; set; }
        string NationalID { get; set; }
        string PatientID { get; set; }
        string LocalPatientName { get; set; }
    }
}
