using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data.Repositorios.PerfiData
{
    public interface IPerfilRepositorio
    {
        void Adiconar<T>(T entidade) where T : class;

        Task<bool> Salvar();

        void AtualizarPerfil<T>(T entidade) where T : class;

        Perfil BuscarPerfil(int id);

        List<Perfil> BuscarPerfis();

        void ExcluirPerfil<T>(T entidade) where T : class;
    }
}
