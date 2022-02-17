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
    public class EstoqueController : ControllerBase
    {
        public readonly EstoqueBussiness EstoqueBussiness;

        public EstoqueController( EstoqueBussiness estoqueBussiness)
        {
            this.EstoqueBussiness = estoqueBussiness;
        }

        [HttpGet("buscar-estoque/{id}")]
        public async Task<ActionResult> BuscarEstoque(int id)
        {

            var estoque = EstoqueBussiness.BuscarEstoque(id);
            return Ok(estoque);
        }
        [HttpGet("exibir-estoques")]
        public ActionResult ExibirEstoques()
        {
            var estoques = EstoqueBussiness.ExibirEstoques();
            return Ok(estoques);
        }
        [HttpPost("salvar-estoque")]
        public async Task<IActionResult> SalvarEstoque(Estoque estoque)
        {
            var _estoque = await EstoqueBussiness.SalvarEstoque(estoque);

            return Ok(_estoque);
        }
        [HttpPut("atualizar-estoque/{id}")]
        public async Task<ActionResult> AtualizarEstoque(Estoque estoque)
        {

            var _estoque = await EstoqueBussiness.AtualizarEstoque(estoque);

            return Ok(_estoque);

        }
        [HttpDelete("excluir-estoque")]
        public async Task<ActionResult> ExcluirEstoque(Estoque estoque)
        {
            await EstoqueBussiness.ExcluirEstoque(estoque);

            return Ok();
        }
    }
}
