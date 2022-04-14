using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TpcBinding.Contracts;


namespace TcpBinding.Service.Servicios
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServicioUsuario : IServiceCPEAP
    {
        public List<List<string>> GetCPEAP()
        {
            return Database.CPEAP.GetCPEAP();
        }
    }
}
