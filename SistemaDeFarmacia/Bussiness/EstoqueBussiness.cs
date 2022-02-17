using SistemaDeFarmacia.Data.Repositorios.EstoqueData;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
    public class EstoqueBussiness
    {
        private readonly IEstoqueRepositorio repositorio;

        public EstoqueBussiness(IEstoqueRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        public Estoque BuscarEstoque(int id)
        {
            var estoque = repositorio.BuscarEstoque(id);
            return estoque;
        }
        public List<Estoque> ExibirEstoques()
        {
            var estoques = repositorio.BuscarEstoques();
            return estoques;
        }

        public async Task<Estoque> SalvarEstoque(Estoque estoque)
        {
            repositorio.Adiconar(estoque);

            if (await repositorio.Salvar())
                return estoque;

            return null;
        }

        public async Task<Estoque> AtualizarEstoque(Estoque estoque)
        {
            repositorio.AtualizarEstoque(estoque);

            if (await repositorio.Salvar())
                return estoque;

            return null;
        }

        public async Task ExcluirEstoque(Estoque estoque)
        {
            repositorio.ExcluirEstoque(estoque);
            await repositorio.Salvar();
        }

    }
}
