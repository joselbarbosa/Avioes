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
        BagagemModel CreateBagagem(BagagemModel model);
        VooModel CreateVoo(VooModel model);
        ReservaModel CreateReserva(ReservaModel model);
        ClienteBagsModel CreateClienteBags(ClienteBagsModel model);
        List<BagagemModel> GetBagagem_All();
    }
}
