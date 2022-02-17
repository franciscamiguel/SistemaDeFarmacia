using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.MedicamentoData
{
    public class MedicamentoRepositorio : IMedicamentoRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public MedicamentoRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }

        public void AtualizarMedicamento<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public Medicamento BuscarMedicamento(int id)
        {
            var Medicamento = context.Medicamentos
                .FirstOrDefault(a => a.Id == id);

            return Medicamento;
        }

        public List<Medicamento> BuscarMedicamentos() 
        {
            return context.Medicamentos.ToList();
        }

        public void ExcluirMedicamento<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
