using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_H.Dtos.Response
{
    public interface IBaseResponse
    {

        ResponseStatus Status { get; set; }
        public string Message { get; set; }


    }
}
