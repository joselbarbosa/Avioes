using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary.Models
{
    public class BagagemModel
    {
        public int Id { get; set; }
        public decimal Peso { get; set; }
        public decimal Cump { get; set; }
        public decimal Larg { get; set; }
        public decimal Alt { get; set; }
        public string Bagtag { get; set; }
        public int IdCliente { get; set; }

        public BagagemModel()
        {
        }
        public BagagemModel(string pesoBagagem, string cumpBagagem, string largBagagem, string altBagagem, string bagtagBagagem, string numCliente)
        {
            decimal pesoBagagemValue = 0;
            decimal.TryParse(pesoBagagem, out pesoBagagemValue);
            Peso = pesoBagagemValue;

            decimal cumpBagagemValue = 0;
            decimal.TryParse(cumpBagagem, out cumpBagagemValue);
            Cump = cumpBagagemValue;

            decimal largBagagemValue = 0;
            decimal.TryParse(largBagagem, out largBagagemValue);
            Larg = largBagagemValue;

            decimal altBagagemValue = 0;
            decimal.TryParse(altBagagem, out altBagagemValue);
            Alt = altBagagemValue;

            Bagtag = bagtagBagagem;

            int numClienteValue = 0;
            int.TryParse(numCliente, out numClienteValue);
            IdCliente = numClienteValue;
        }
    }
}
