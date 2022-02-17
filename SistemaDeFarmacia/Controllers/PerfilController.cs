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
    public class PerfilController : ControllerBase
    {
        public readonly PerfilBussiness PerfilBussiness;

        public PerfilController( PerfilBussiness perfilBussiness)
        {
            this.PerfilBussiness = perfilBussiness;
        }

        [HttpGet("buscar-perfil/{id}")]
        public async Task<ActionResult> Buscarperfil(int id)
        {

            var perfil = PerfilBussiness.BuscarPerfis(id);
            return Ok(perfil);
        }
        [HttpGet("exibir-perfis")]
        public ActionResult Exibirperfis()
        {
            var perfis = PerfilBussiness.ExibirPerfis();
            return Ok(perfis);
        }

        [HttpPost("salvar-perfil")]
        public async Task<IActionResult> SalvarPerfil(Perfil perfil)
        {
            var _perfil = await PerfilBussiness.SalvarPerfil(perfil);

            return Ok(_perfil);
        }

        [HttpPut("atualizar-perfil/{id}")]
        public async Task<ActionResult> Atualizarperfil(Perfil perfil)
        {

            var _perfil = await PerfilBussiness.AtualizarPerfil(perfil);

            return Ok(_perfil);

        }

        [HttpDelete("excluir-perfil")]
        public async Task<ActionResult> Excluirperfil(Perfil perfil)
        {
            await PerfilBussiness.ExcluirPerfil(perfil);

            return Ok();
        }
    }
}
