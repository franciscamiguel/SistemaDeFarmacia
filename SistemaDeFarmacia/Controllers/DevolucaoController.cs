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
    public class DevolucaoController : ControllerBase
    {
        public readonly DevolucaoBussiness DevolucaoBussiness;

        public DevolucaoController( DevolucaoBussiness devolucaoBussiness)
        {
            this.DevolucaoBussiness = devolucaoBussiness;
        }

        [HttpGet("buscar-devolucao/{id}")]
        public async Task<ActionResult> BuscarDevolucao(int id)
        {

            var devolucao = DevolucaoBussiness.BuscarDevolucao(id);
            return Ok(devolucao);
        }
        [HttpGet("exibir-devolucoes")]
        public ActionResult ExibirDevolucoes()
        {
            var devolucaos = DevolucaoBussiness.ExibiDevolucaos();
            return Ok(devolucaos);
        }
        [HttpPost("salvar-devolucao")]
        public async Task<IActionResult> SalvarDevolucao(Devolucao devolucao)
        {
            var _devolucao = await DevolucaoBussiness.SalvarDevolucao(devolucao);

            return Ok(_devolucao);
        }
        [HttpPut("atualizar-devolucao/{id}")]
        public async Task<ActionResult> AtualizarDevolucao(Devolucao devolucao)
        {

            var _devolucao = await DevolucaoBussiness.AtualizarDevolucao(devolucao);

            return Ok(_devolucao);

        }
        [HttpDelete("excluir-devolucao")]
        public async Task<ActionResult> ExcluirDevolucao(Devolucao devolucao)
        {
            await DevolucaoBussiness.ExcluirDevolucao(devolucao);

            return Ok();
        }
    }
}
