using SistemaDeFarmacia.Data.Repositorios.DescontoData;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
   public class DescontoBussiness
   {
        private readonly IDescontoRepositorio repositorio;
        public DescontoBussiness(IDescontoRepositorio repositorio)
        {
            this.repositorio = repositorio;

        }
        public Desconto BuscarDesconto(int id)
        {
            var desconto = repositorio.BuscarDesconto(id);
            return desconto;
        }
        public List<Desconto> ExibirDescontos()
        {
            var descontos = repositorio.BuscarDescontos();
            return descontos;
        }
        public async Task<Desconto> SalvarDesconto(Desconto desconto)
        {
            repositorio.Adiconar(desconto);

            if (await repositorio.Salvar())
                return desconto;

            return null;
        }
        public async Task<Desconto> AtualizarDesconto(Desconto desconto)
        {
            repositorio.AtualizarDesconto(desconto);

            if (await repositorio.Salvar())
                return desconto;

            return null;
        }
        public async Task ExcluirDesconto(Desconto desconto)
        {
            repositorio.ExcluirDesconto(desconto);
            await repositorio.Salvar();
        }

    }
}
