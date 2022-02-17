using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.DevolucaoData
{
   public interface IDevolucaoRepositorio
   {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarDevolucao<T>(T entidade) where T : class;

        Devolucao BuscarDevolucao(int id);

        List<Devolucao> BuscarDevolucaos();

        void ExcluirDevolucao<T>(T entidade) where T : class;
    }
}
