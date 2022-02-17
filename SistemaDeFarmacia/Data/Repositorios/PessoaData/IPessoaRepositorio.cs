using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.PessoaData
{
    public interface IPessoaRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarPessoa<T>(T entidade) where T : class;

        Pessoa BuscarPessoa(int id);

        List<Pessoa> BuscarPessoas();

        void ExcluirPessoa<T>(T entidade) where T : class;
    }
}
