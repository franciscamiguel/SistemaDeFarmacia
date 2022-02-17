using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.PerfiData
{
    public class PerfilRepositorio : IPerfilRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public PerfilRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void AtualizarPerfil<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }

        public Perfil BuscarPerfil(int id)
        {
            var Perfil = context.Perfis
                 .FirstOrDefault(a => a.Id == id);

            return Perfil;
        }

        public List<Perfil> BuscarPerfis()
        {
            return context.Perfis.ToList();
        }

        public void ExcluirPerfil<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
