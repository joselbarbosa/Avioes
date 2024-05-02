using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvioesLibrary.Models;

namespace AvioesLibrary.DataAccess
{
    public interface IDataConnection
    {
        ClienteModel CreateCliente(ClienteModel model);
    }
}
