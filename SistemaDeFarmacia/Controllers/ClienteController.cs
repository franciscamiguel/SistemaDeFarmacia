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
    public class ClienteController : ControllerBase
    {
        public readonly ClienteBussiness ClienteBussiness;
        public ClienteController(ClienteBussiness clienteBusiness)
        {
            this.ClienteBussiness = clienteBusiness;
        }

        [HttpGet("buscar-cliente/{id}")]
        public async Task<ActionResult> BuscarCliente(int id)
        {

            var cliente =  await ClienteBussiness.BuscarCliente(id);
            return Ok(cliente);
        }
        [HttpGet("exibir-clientes")]
        public async Task<ActionResult> ExibirClientes()
        {
            var clientes = await ClienteBussiness.ExibirClientes();
            return Ok(clientes);
        }
        /// <returns></returns>
        [HttpPost("salvar-cliente")]
        public async Task<IActionResult> SalvarCliente(Cliente cliente)
        {
            var _cliente = await ClienteBussiness.SalvarCliente(cliente);

            return Ok(cliente);
        }

        [HttpPut("atualizar-cliente/{id}")]
        public async Task<ActionResult> AtualizarCliente(Cliente cliente)
        {

            var _cliente = await ClienteBussiness.AtualizarCliente(cliente);

            return Ok(_cliente);

        }

        [HttpDelete("excluir-cliente")]
        public async Task<ActionResult> ExcluirCliente(Cliente cliente)
        {
            await ClienteBussiness.ExcluirCliente(cliente);

            return Ok();
        }
    }
}
