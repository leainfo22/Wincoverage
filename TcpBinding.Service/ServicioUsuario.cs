using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TpcBinding.Contracts;

namespace TcpBinding.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServicioUsuario : IServiceUsuario
    {
        public List<List<string>> GetUsuarios()
        {            
            return Database.Usuarios.GetUsuarios();
        }
    }
}
