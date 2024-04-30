using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary
{
    internal class PagamentoModel
    {
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public string MetodoPagamento { get; set; }
        public string NumCartao { get; set; }
    }
}
