using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary
{
    internal class VooModel
    {
        public int Id { get; set; }
        public string NumVoo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataPartida { get; set; }
        public DateTime DataChegada { get; set; }
        public byte LugaresDisponiveis { get; set; }
    }
}
