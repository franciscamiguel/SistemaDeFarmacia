using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.DevolucaoData
{
    public class DevolucaoRepositorio : IDevolucaoRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public DevolucaoRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void AtualizaDevolucao<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }

        public void AtualizarDevolucao<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }

        public Devolucao BuscarDevolucao(int id)
        {
            var Devolucao = context.Devolucaos
                .FirstOrDefault(a => a.Id == id);

            return Devolucao;
        }

        public List<Devolucao> BuscarDevolucaos()
        {
            return context.Devolucaos.ToList();
        }

        public void ExcluirDevolucao<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
