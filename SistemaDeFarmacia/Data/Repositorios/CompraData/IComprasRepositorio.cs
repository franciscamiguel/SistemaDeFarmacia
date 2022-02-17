using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.CompraData
{
   public interface IComprasRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarCompra<T>(T entidade) where T : class;

        Compra BuscarCompra(int id);

        List<Compra> BuscarCompras();

        void ExcluirCompra<T>(T entidade) where T : class;
    }
}
