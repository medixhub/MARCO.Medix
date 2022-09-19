using System.ComponentModel.DataAnnotations;

namespace Medix.Common.Demo.Models
{
    public class IssueCode
    {
        [Key]
        public int Id { get; set; }
        public string StudyInstanceUID { get; set; }
        public string Code { get; set; }
    }
}
