using System;
using System.Collections.Generic;
using System.Linq;
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
        string MobileNumber { get; set; }
        string StudyInstanceUID { get; set; }
        string PatientName { get; set; }
        string ServerID { get; set; }
        string StudyDate { get; set; }
        string NodeId { get; set; }
        string ReferringPhysicianId { get; set; }
        string InstitutionId { get; set; }
        string SendTo { get; set; }

    }
}
