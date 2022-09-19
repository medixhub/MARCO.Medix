using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Medix.Common.Demo.Models
{
    public class Study
    {
        [Key]
        public int Id { get; set; }
        public string MobileNumber { get; set; }
        public string StudyInstanceUID { get; set; }
        public string PatientName { get; set; }
        public string ServerID { get; set; }
        public string StudyDate { get; set; }
        public string NodeId { get; set; }
        public string ReferringPhysicianId { get; set; }
        public string InstitutionId { get; set; }
        public string SendTo { get; set; }
        public bool IssueImmediate { get; set; }
        public string NationalID { get; set; }
        public string PatientID { get; set; }
        public string LocalPatientName { get; set; }
    }
}
