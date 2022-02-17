using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public string Unidade { get; set; }
        public string Produto { get; set; }
        public string Preço { get; set; }
    }
}
