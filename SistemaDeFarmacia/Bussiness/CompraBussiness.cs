using SistemaDeFarmacia.Data.Repositorios.CompraData;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
    public class CompraBussiness
    {
        private readonly IComprasRepositorio repositorio;
        public CompraBussiness(IComprasRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        public Compra BuscarCompra(int id)
        {
            var compra = repositorio.BuscarCompra(id);
            return compra;
        }
        public List<Compra> ExibirCompras()
        {
            var compras = repositorio.BuscarCompras();
            return compras;
        }
        public async Task<Compra> SalvarCompra(Compra compra)
        {
            repositorio.Adiconar(compra);

            if (await repositorio.Salvar())
                return compra;

            return null;
        }
        public async Task<Compra> AtualizarCompra(Compra compra)
        {
            repositorio.AtualizarCompra(compra);

            if (await repositorio.Salvar())
                return compra;

            return null;
        }
        public async Task ExcluirCompra(Compra compra)
        {
            repositorio.ExcluirCompra(compra);
            await repositorio.Salvar();
        }

    }
}
