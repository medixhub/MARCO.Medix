using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Medix.Dtos.Medix_H.Request
{
    public interface IGetIssuedCodesRequest
    {
        string StudyInstanceUID { get; set; }
    }
}
