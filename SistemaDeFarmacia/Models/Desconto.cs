using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Models
{
    public class Desconto
    {
        public int Id { get; set; }
        public string SubTotal { get; set; }
        public string Avista { get; set; }
        public double valor { get; set; }
        public double TotalParcial { get; set; }
    }
}
