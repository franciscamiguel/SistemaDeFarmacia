using SistemaDeFarmacia.Data.Repositorios;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Bussiness
{
    public class ClienteBussiness 
    {
        private readonly IClienteRepositorio repositorio;
        public ClienteBussiness(IClienteRepositorio repositorio)
        {
            this.repositorio = repositorio;

        }
        public async Task<Cliente> BuscarCliente(int id)
        {
            var cliente = await repositorio.BuscarCliente(id);
            return cliente;
        }

        public async Task<List<Cliente>> ExibirClientes()
        {
            var clientes = await repositorio.BuscarClientes();
            return clientes;
        }
        public async Task<Cliente> SalvarCliente(Cliente cliente)
        {
            repositorio.Adiconar(cliente);

            if (await repositorio.Salvar())
                return cliente;

            return null;
        }
        public async Task<Cliente> AtualizarCliente(Cliente cliente)
        {
            repositorio.AtualizarCliente(cliente);

            if (await repositorio.Salvar())
                return cliente;

            return null;
        }

        public async Task ExcluirCliente(Cliente cliente)
        {
            repositorio.ExcluirCliente(cliente);
            await repositorio.Salvar();
        }


    }
}
