using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MARCO.Medix.Dtos
{
    [DataContract]
    public class BaseResponse : IBaseResponse
    {
        [DataMember]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [EnumDataType(typeof(ResponseStatus))]
        public ResponseStatus Status { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}
