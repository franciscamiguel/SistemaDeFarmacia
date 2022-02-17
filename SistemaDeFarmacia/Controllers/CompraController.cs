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
    public class CompraController : ControllerBase
    {

        public readonly CompraBussiness CompraBussiness;

        public CompraController(CompraBussiness compraBusiness)
        {
            this.CompraBussiness = compraBusiness;
        }

        [HttpGet("buscar-compra/{id}")]
        public async Task<ActionResult> BuscarCompra(int id)
        {

            var compra = CompraBussiness.BuscarCompra(id);
            return Ok(compra);
        }
        [HttpGet("exibir-compras")]
        public ActionResult ExibirCompras()
        {
            var compras = CompraBussiness.ExibirCompras();
            return Ok(compras);
        }
        [HttpPost("salvar-compra")]
        public async Task<IActionResult> SalvarCompra(Compra compra)
        {
            var _compra = await CompraBussiness.SalvarCompra(compra);

            return Ok(_compra);
        }
        [HttpPut("atualizar-compra/{id}")]
        public async Task<ActionResult> AtualizarCompra(Compra compra)
        {

            var _compra = await CompraBussiness.AtualizarCompra(compra);

            return Ok(_compra);

        }
        [HttpDelete("excluir-compra")]
        public async Task<ActionResult> ExcluirCompra(Compra compra)
        {
            await CompraBussiness.ExcluirCompra(compra);

            return Ok();
        }
    }
}
