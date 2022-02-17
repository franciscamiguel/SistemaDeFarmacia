using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.CompraData
{
    public class ComprasRepositorio : IComprasRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;


        public ComprasRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }
        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void AtualizarCompra<T>(T entidade) where T : class
        {
            context.Update(entidade);
        }

        public Compra BuscarCompra(int id)
        {
            var compra = context.Compras
                .FirstOrDefault(a => a.Id == id);
            return compra;
        }

        public List<Compra> BuscarCompras()
        {
            return context.Compras.ToList();
        }

        public void ExcluirCompra<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
   
}
