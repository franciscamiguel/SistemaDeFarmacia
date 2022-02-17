using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.PessoaData
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;


        public PessoaRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void AtualizarPessoa<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }

        public Pessoa BuscarPessoa(int id)
        {
            var Pessoa = context.Pessoas
                 .FirstOrDefault(a => a.Id == id);

            return Pessoa;
        }

        public List<Pessoa> BuscarPessoas()
        {
            return context.Pessoas.ToList();
        }

        public void ExcluirPessoa<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
