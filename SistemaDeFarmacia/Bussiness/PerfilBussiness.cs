using SistemaDeFarmacia.Data.Repositorios.PerfiData;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
    public class PerfilBussiness
    {
        private readonly IPerfilRepositorio repositorio;
        public PerfilBussiness(IPerfilRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public Perfil BuscarPerfis(int id)
        {
            var perfil = repositorio.BuscarPerfil(id);
            return perfil;

        }
        public List<Perfil> ExibirPerfis()
        {
            var perfis = repositorio.BuscarPerfis();
            return perfis;
        }
        public async Task<Perfil> SalvarPerfil(Perfil perfil)
        {
            repositorio.Adiconar(perfil);

            if (await repositorio.Salvar())
                return perfil;

            return null;
        }
        public async Task<Perfil> AtualizarPerfil(Perfil Perfil)
        {
            repositorio.AtualizarPerfil(Perfil);

            if (await repositorio.Salvar())
                return Perfil;

            return null;
        }
        public async Task ExcluirPerfil(Perfil perfil)
        {
            repositorio.ExcluirPerfil(perfil);
            await repositorio.Salvar();
        }
    }
}
