﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos.Medix_H
{
    public interface IPhysician
    {
        public string PhysicianId { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Specialty { get; set; }
        public DateTime InsertDate { get; set; }
        public string RefuteDescription { get; set; }
       
    }
    public enum Gender
    {
        Male,
        Female,
        Other,
      
    }

}
