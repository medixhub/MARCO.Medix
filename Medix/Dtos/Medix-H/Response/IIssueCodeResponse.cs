using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
 

namespace Medix.Dtos.Medix_H.Response
{
  
    public interface IIssueCodeResponse 
    {
        public string Code { get; set; }
   
        public string StudyInstanceUID { get; set; }
    }
}
