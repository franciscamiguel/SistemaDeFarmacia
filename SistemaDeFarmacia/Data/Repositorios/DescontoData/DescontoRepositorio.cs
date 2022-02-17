using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.DescontoData
{
    public class DescontoRepositorio : IDescontoRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;


        public DescontoRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }
        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void AtualizarDesconto<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }

        public Desconto BuscarDesconto(int id)
        {
            var Desconto = context.Descontos
                  .FirstOrDefault(a => a.Id == id);

            return Desconto;
        }

        public List<Desconto> BuscarDescontos()
        {
            return context.Descontos.ToList();
        }

        public void ExcluirDesconto<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
