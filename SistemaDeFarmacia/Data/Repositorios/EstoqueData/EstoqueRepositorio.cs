using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.EstoqueData
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public EstoqueRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void AtualizarEstoque<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }

        public Estoque BuscarEstoque(int id)
        {
            var Estoque = context.Estoques
               .FirstOrDefault(a => a.Id == id);

            return Estoque;
        }

        public List<Estoque> BuscarEstoques()
        {
            return context.Estoques.ToList();
        }
       
        public void ExcluirEstoque<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
