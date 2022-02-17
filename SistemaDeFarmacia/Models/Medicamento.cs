using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string Produto{ get; set; }
        public string Registro { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
