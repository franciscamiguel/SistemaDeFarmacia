using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Models
{
    public class Perfil
    {
        public int Id { get; set; }
        public string Programador { get; set; }
        public string Conhecimentos { get; set; }
        public string Habilidades { get; set; }
        public string Conquistas { get; set; }
    }
}
