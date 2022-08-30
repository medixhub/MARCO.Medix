﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_N.Dtos.Request
{
    public interface IDownloadStudyRequest
    {
        [DataMember]
        public string StudyInstanceUID { get; set; }
        [DataMember]
        public string PatientID { get; set; }
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public string WebhookUri { get; set; }
        [DataMember]
        public string Token { get; set; }
    }
}