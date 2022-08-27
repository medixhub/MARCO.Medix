using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_H.Dtos.Response
{
    public interface IHCodeResponse : IBaseResponse
    {
        public string HCode { get; set; }
    }
}
