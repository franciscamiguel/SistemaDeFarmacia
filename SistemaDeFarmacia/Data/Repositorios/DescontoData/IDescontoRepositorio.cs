using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.DescontoData
{
   public interface IDescontoRepositorio
   {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarDesconto<T>(T entidade) where T : class;

        Desconto BuscarDesconto(int id);

        List<Desconto> BuscarDescontos();

        void ExcluirDesconto<T>(T entidade) where T : class;
       
    }
}
