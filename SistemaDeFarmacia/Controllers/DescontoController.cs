using Microsoft.AspNetCore.Mvc;
using SistemaDeFarmacia.Bussiness;
using SistemaDeFarmacia.Data;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class DescontoController : ControllerBase
    {
        private readonly IRepositorio repositorio;
        public readonly DescontoBussiness DescontoBussiness;

        public DescontoController(IRepositorio repositorio,DescontoBussiness descontoBusiness)
        {
            this.repositorio = repositorio;
            this.DescontoBussiness = descontoBusiness;
        }
        [HttpGet("buscar-desconto/{id}")]
        public async Task<ActionResult> BuscarDesconto(int id)
        {

            var desconto = DescontoBussiness.BuscarDesconto(id);
            return Ok(desconto);
        }
        [HttpGet("exibir-descontos")]
        public ActionResult ExibirDescontos()
        {
            var descontos = DescontoBussiness.ExibirDescontos();
            return Ok(descontos);
        }
        [HttpPost("salvar-desconto")]
        public async Task<IActionResult> SalvarDesconto(Desconto desconto)
        {
            var _desconto = await DescontoBussiness.SalvarDesconto(desconto);

            return Ok(_desconto);
        }
        [HttpPut("atualizar-desconto/{id}")]
        public async Task<ActionResult> AtualizarDesconto(Desconto desconto)
        {

            var _desconto = await DescontoBussiness.AtualizarDesconto(desconto);

            return Ok(_desconto);

        }
        [HttpDelete("excluir-desconto")]
        public async Task<ActionResult> ExcluirDesconto(Desconto desconto)
        {
            await DescontoBussiness.ExcluirDesconto(desconto);

            return Ok();
        }
    }
}
