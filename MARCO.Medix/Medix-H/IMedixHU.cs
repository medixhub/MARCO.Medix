using MARCO.Medix.Medix_H.Dtos.Request;
using MARCO.Medix.Medix_H.Dtos.Response;
using MARCO.Medix.Medix_H.Dtos;
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
        public IHCodeResponse GetHCode(IHCodeRequest codeRequest);
        public IAsyncEnumerable<IPhysician> GetPhysicians(string query);
    }
}
