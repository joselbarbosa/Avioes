using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary.Models
{
    public class VooModel
    {
        public int Id { get; set; }
        public string NumVoo { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime DataPartida { get; set; }
        public DateTime DataChegada { get; set; }
        public byte LugaresDisponiveis { get; set; }

        public VooModel()
        {
        }
        public VooModel(string numVoo, string origem, string destino, string dataPartida, string dataChegada, string lugaresDisponiveis)
        {
            NumVoo = numVoo;
            Origem = origem;
            Destino = destino;

            DateTime partidaVooValue = DateTime.Now;
            DateTime.TryParse(dataPartida, out partidaVooValue);
            DataPartida = partidaVooValue;

            DateTime chegadaVooValue = DateTime.Now;
            DateTime.TryParse(dataChegada, out chegadaVooValue);
            DataChegada = chegadaVooValue;

            byte lugaresDisponiveisValue = 0;
            byte.TryParse(lugaresDisponiveis, out lugaresDisponiveisValue);
            LugaresDisponiveis = lugaresDisponiveisValue;
        }
    }
}
