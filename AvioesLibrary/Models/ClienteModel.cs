using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvioesLibrary.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Passaporte { get; set; }

        public ClienteModel()
        {
        }
        public ClienteModel(string nomeCliente, string emailCliente, string telefoneCliente, string passaporteCliente)
        {
            Nome = nomeCliente;
            Email = emailCliente;
            Telefone = telefoneCliente;
            Passaporte = passaporteCliente;
        }
    }
}
