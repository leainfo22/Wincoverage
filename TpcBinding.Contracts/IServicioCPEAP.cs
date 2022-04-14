using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TpcBinding.Contracts
{
    [ServiceContract]
    public interface IServiceCPEAP
    {
        [OperationContract]
        List<List<string>> GetCPEAP();
    }
}
