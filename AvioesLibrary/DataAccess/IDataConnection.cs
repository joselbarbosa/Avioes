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
        BagagemModel DeleteBagagem(BagagemModel model);
        BagagemModel UpdateBagagem(BagagemModel model);
        List<BagagemModel> GetBagagem_All();
        VooModel CreateVoo(VooModel model);
        ReservaModel CreateReserva(ReservaModel model);
        ReservaModel DeleteReserva(ReservaModel model);

        // Interface que não está em uso
        ClienteBagsModel CreateClienteBags(ClienteBagsModel model);
    }
}
