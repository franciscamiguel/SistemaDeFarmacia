using SistemaDeFarmacia.Data.Repositorios.DevolucaoData;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
    public class DevolucaoBussiness
    {
        private readonly IDevolucaoRepositorio repositorio;

        public DevolucaoBussiness(IDevolucaoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }
        public Devolucao BuscarDevolucao(int id)
        {
            var devolucao = repositorio.BuscarDevolucao(id);
            return devolucao;
        }
        public List<Devolucao> ExibiDevolucaos()
        {
            var devolucaos = repositorio.BuscarDevolucaos();
            return devolucaos;
        }
        public async Task<Devolucao> SalvarDevolucao(Devolucao devolucao)
        {
            repositorio.Adiconar(devolucao);

            if (await repositorio.Salvar())
                return devolucao;

            return null;
        }
        public async Task<Devolucao> AtualizarDevolucao(Devolucao devolucao)
        {
            repositorio.AtualizarDevolucao(devolucao);

            if (await repositorio.Salvar())
                return devolucao;

            return null;
        }
        public async Task ExcluirDevolucao(Devolucao devolucao)
        {
            repositorio.ExcluirDevolucao(devolucao);
            await repositorio.Salvar();
        }
    }
}
