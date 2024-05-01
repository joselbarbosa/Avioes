using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary
{
    public class SqlConnector : IDataConnection
    {
        public ClienteModel CreateCliente(ClienteModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
