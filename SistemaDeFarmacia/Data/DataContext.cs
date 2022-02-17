using Microsoft.EntityFrameworkCore;
using SistemaDeFarmacia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeFarmacia.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
             base(options)
        { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Desconto> Descontos { get; set; }
        public DbSet<Devolucao> Devolucaos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
