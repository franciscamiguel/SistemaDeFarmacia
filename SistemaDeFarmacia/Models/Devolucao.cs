using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Models
{
    public class Devolucao
    {
        public int Id { get; set; }
        public string CódigoProduto { get; set; }
        public string DescriçãoDProduto { get; set; }
        public string Unidade { get; set; }
        public string Quantidade{ get; set; }
        public string ValorUnitario { get; set; }
        public string ValorTotal { get; set; }
        public string Prazo { get; set; }
    }
}
