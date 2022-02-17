using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.EstoqueData
{
    public interface IEstoqueRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarEstoque<T>(T entidade) where T : class;

        Estoque BuscarEstoque(int id);

        List<Estoque> BuscarEstoques();

        void ExcluirEstoque<T>(T entidade) where T : class;
    }
}
