using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos.Medix_H
{
    public class IPhysician
    {
        public string PhysicianId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Specialty { get; set; }
        public string Status { get; set; }
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string RefuteDescription { get; set; }
       
    }
  
}
