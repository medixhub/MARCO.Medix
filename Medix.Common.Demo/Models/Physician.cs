using Medix.Dtos;
using System.Text.Json.Serialization;

namespace Medix.Common.Demo.Models
{
    public class Physician : IPhysician
    {
        public string PhysicianId { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Specialty { get; set; }
        public DateTime InsertDate { get; set; }
        public string RefuteDescription { get; set; }
    }
}
