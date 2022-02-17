using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios
{
   public interface IClienteRepositorio
   {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarCliente<T>(T entidade) where T : class;

        Task<Cliente> BuscarCliente(int id);

        Task<List<Cliente>> BuscarClientes();

        void ExcluirCliente<T>(T entidade) where T : class;

    }
}
