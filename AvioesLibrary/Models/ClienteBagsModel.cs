using AvioesLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary
{
    public class ClienteBagsModel
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdBagagem { get; set; }

        public ClienteBagsModel()
        {
        }
        public ClienteBagsModel(int idCliente, List<BagagemModel> idBagagem)
        {
        }
    }
}
