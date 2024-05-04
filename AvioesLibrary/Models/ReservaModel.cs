using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary.Models
{
    public class ReservaModel
    {
        public int Id { get; set; }
        public int VooReserva { get; set; }
        public int ClienteReserva { get; set; }
        public DateTime DataReserva { get; set; }
        public string LugarReserva { get; set; }

        public ReservaModel()
        {
            DataReserva = DateTime.Now;
        }
        public ReservaModel(string vooReserva, string clienteReserva, string lugarReserva)
        {
            int vooReservaValue = 0;
            int.TryParse(vooReserva, out vooReservaValue);
            VooReserva = vooReservaValue;

            int clienteReservaValue = 0;
            int.TryParse(clienteReserva, out clienteReservaValue);
            ClienteReserva = clienteReservaValue;

            DataReserva = DateTime.Now;

            LugarReserva = lugarReserva;
        }
    }
}
