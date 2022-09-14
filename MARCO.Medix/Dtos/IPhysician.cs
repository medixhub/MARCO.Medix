using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos
{
    public interface IPhysician
    {
        public string PhysicianId { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Specialty { get; set; }
        public DateTime InsertDate { get; set; }
        public string RefuteDescription { get; set; }

    }
    

}
