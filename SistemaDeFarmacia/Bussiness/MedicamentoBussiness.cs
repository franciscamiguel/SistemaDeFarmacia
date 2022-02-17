using SistemaDeFarmacia.Data.Repositorios.MedicamentoData;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
    public class MedicamentoBussiness
    {
        private readonly IMedicamentoRepositorio repositorio;

        public MedicamentoBussiness(IMedicamentoRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Medicamento BuscarMedicamento(int id)
        {
            var medicamento = repositorio.BuscarMedicamento(id);
            return medicamento;
        }

        public List<Medicamento> ExibirMedicamentos()
        {
            var medicamentos = repositorio.BuscarMedicamentos();
            return medicamentos;
        }

        public async Task<Medicamento> SalvarMedicamento(Medicamento medicamento)
        {
            repositorio.Adiconar(medicamento);

            if (await repositorio.Salvar())
                return medicamento;

            return null;
        }

        public async Task<Medicamento> AtualizarMedicamento(Medicamento medicamento)
        {
            repositorio.AtualizarMedicamento(medicamento);

            if (await repositorio.Salvar())
                return medicamento;

            return null;
        }

        public async Task ExcluirMedicamento(Medicamento medicamento)
        {
            repositorio.ExcluirMedicamento(medicamento);
            await repositorio.Salvar();
        }

    }
}
