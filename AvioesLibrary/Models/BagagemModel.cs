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
        public bool Fragil { get; set; }
    }
}
