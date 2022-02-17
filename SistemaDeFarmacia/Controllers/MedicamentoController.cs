using Microsoft.AspNetCore.Mvc;
using SistemaDeFarmacia.Bussiness;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class MedicamentoController : ControllerBase
    {

        public readonly MedicamentoBussiness MedicamentoBussiness;

        public MedicamentoController(MedicamentoBussiness medicamentoBussiness)
        {
            this.MedicamentoBussiness = medicamentoBussiness;
        }

        [HttpGet("buscar-medicamento/{id}")]
        public async Task<ActionResult> BuscarMedicamento(int id)
        {

            var medicamento = MedicamentoBussiness.BuscarMedicamento(id);
            return Ok(medicamento);
        }

        [HttpGet("exibir-medicamentos")]
        public ActionResult ExibirMedicamentos()
        {
            var medicamentos = MedicamentoBussiness.ExibirMedicamentos();
            return Ok(medicamentos);
        }
        [HttpPost("salvar-medicamento")]
        public async Task<IActionResult> SalvarMedicamento(Medicamento medicamento)
        {
            var _medicamento = await MedicamentoBussiness.SalvarMedicamento(medicamento);

            return Ok(_medicamento);
        }

        [HttpPut("atualizar-medicamento/{id}")]
        public async Task<ActionResult> AtualizarMedicamento(Medicamento medicamento)
        {

            var _medicamento = await MedicamentoBussiness.AtualizarMedicamento(medicamento);

            return Ok(_medicamento);

        }
        [HttpDelete("excluir-medicamento")]
        public async Task<ActionResult> ExcluirMedicamento(Medicamento medicamento)
        {
            await MedicamentoBussiness.ExcluirMedicamento(medicamento);

            return Ok();
        }
    }
}
