using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public string Unidade { get; set; }
        public string Categoria { get; set; }
        public string Preço { get; set; }
        public string Venda { get; set; }
        public string CustoTotal { get; set; }


    }
}
