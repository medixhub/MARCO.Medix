
using MARCO.Medix.Dtos.Medix_H;
using MARCO.Medix.Dtos.Medix_H.Request;
using MARCO.Medix.Dtos.Medix_H.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MARCO.Medix.Medix_H
{
    public interface IMedixHU
    {
        public ICodeResponse GetHCode(IHCodeRequest codeRequest);
        public IAsyncEnumerable<IPhysician> GetPhysicians(string query);
    }
}
