using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace SistemaDeFarmacia.Data.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly DataContext context;
        private readonly IRepositorio repositorio;

        public ClienteRepositorio(DataContext context, IRepositorio repositorio)
        {
            this.context = context;
            this.repositorio = repositorio;
        }

        public void Adiconar<T>(T entidade) where T : class
        {
            repositorio.Adiconar(entidade);
        }

        public void AtualizarCliente<T>(T entidade) where T : class
        {
            repositorio.Atualizar(entidade);
        }


        public async Task<Cliente> BuscarCliente(int id)
        {

            var Cliente = await context.Clientes
                .FirstOrDefaultAsync(a => a.Id == id);

            return Cliente;
        }

        public async Task<List<Cliente>> BuscarClientes()
        {
            return await context.Clientes.ToListAsync();
        }

        public void ExcluirCliente<T>(T entidade) where T : class
        {
            repositorio.Excluir(entidade);
        }

        public async Task<bool> Salvar()
        {
            return await repositorio.Salvar();
        }
    }
}
