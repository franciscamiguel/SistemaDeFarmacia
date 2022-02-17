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
    public class PessoaController : ControllerBase
    {
        public readonly PessoaBussiness PessoaBussiness;

        public PessoaController(PessoaBussiness pessoaBussiness)
        {
            this.PessoaBussiness = pessoaBussiness;
        }
        [HttpGet("buscar-pessoa/{id}")]
        public async Task<ActionResult> Buscarpessoa(int id)
        {

            var pessoa = PessoaBussiness.BuscarPessoa(id);
            return Ok(pessoa);
        }

        [HttpGet("exibir-pessoas")]
        public ActionResult ExibirPessoas()
        {
            var pessoas = PessoaBussiness.ExibirPessoas();
            return Ok(pessoas);
        }

        [HttpPost("salvar-pessoa")]
        public async Task<IActionResult> SalvarPessoa(Pessoa pessoa)
        {
            var _pessoa = await PessoaBussiness.SalvarPessoa(pessoa);

            return Ok(_pessoa);
        }

        [HttpPut("atualizar-pessoa/{id}")]
        public async Task<ActionResult> AtualizarPessoa(Pessoa pessoa)
        {

            var _pessoa = await PessoaBussiness.AtualizarPessoa(pessoa);

            return Ok(_pessoa);

        }

        [HttpDelete("excluir-pessoa")]
        public async Task<ActionResult> ExcluirPessoa(Pessoa pessoa)
        {
            await PessoaBussiness.ExcluirPessoa(pessoa);

            return Ok();
        }
    }
}
