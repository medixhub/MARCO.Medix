using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Medix.Dtos.Medix_N.Request
{
    public interface IDownloadStudyRequest
    {
       
        public string StudyInstanceUID { get; set; }
        public string PatientID { get; set; }
        public string FileName { get; set; }
        public string WebhookUri { get; set; }
     
    }
}
