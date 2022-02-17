using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.MedicamentoData
{
   public interface IMedicamentoRepositorio
   {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarMedicamento<T>(T entidade) where T : class;

        Medicamento BuscarMedicamento(int id);

        List<Medicamento> BuscarMedicamentos();

        void ExcluirMedicamento<T>(T entidade) where T : class;
    }
}
