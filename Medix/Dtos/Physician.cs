using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Medix.Dtos
{
    [DataContract]
    public class Physician : IPhysician
    {
        [DataMember]
        public string PhysicianId { get; set; }
        [DataMember]
        public string Name { get; set; }
       
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Specialty { get; set; }
        [DataMember]
        public DateTime InsertDate { get; set; }
        [DataMember]
        public string RefuteDescription { get; set; }
    }
}
