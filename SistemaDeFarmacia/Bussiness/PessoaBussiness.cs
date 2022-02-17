using SistemaDeFarmacia.Data.Repositorios.PessoaData;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
    public class PessoaBussiness
    {
        private readonly IPessoaRepositorio repositorio;

        public PessoaBussiness(IPessoaRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        public Pessoa BuscarPessoa(int id)
        {
            var pessoa = repositorio.BuscarPessoa(id);
            return pessoa;
        }
        public List<Pessoa> ExibirPessoas()
        {
            var pessoas = repositorio.BuscarPessoas();
            return pessoas;
        }

        public async Task<Pessoa> SalvarPessoa(Pessoa pessoa)
        {
            repositorio.Adiconar(pessoa);

            if (await repositorio.Salvar())
                return pessoa;

            return null;
        }
        public async Task<Pessoa> AtualizarPessoa(Pessoa pessoa)
        {
            repositorio.AtualizarPessoa(pessoa);

            if (await repositorio.Salvar())
                return pessoa;

            return null;
        }
        public async Task ExcluirPessoa(Pessoa pessoa)
        {
            repositorio.ExcluirPessoa(pessoa);
            await repositorio.Salvar();
        }

    }
}
