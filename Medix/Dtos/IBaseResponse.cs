using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Medix.Dtos
{

    public interface IBaseResponse
    {
        [EnumDataType(typeof(ResponseStatus))]
        ResponseStatus Status { get; set; }
        public string Message { get; set; }


    }
}
