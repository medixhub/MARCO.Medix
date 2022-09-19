using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Medix.Dtos.Medix_N.Request
{
    [DataContract]
    public class DownloadStudyRequest: IDownloadStudyRequest
    {

        [DataMember]
        public string StudyInstanceUID { get; set; }
        [DataMember]
        public string PatientID { get; set; }
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public string WebhookUri { get; set; }
    }
}
