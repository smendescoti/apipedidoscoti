using ApiPedidos.Domain.Entities;
using ApiPedidos.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiPedidos.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Construtor para injeção de dependência
        /// </summary>
        /// <param name="options">Parametro contendo todas as info para conexão com o banco de dados</param>
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new CobrancaConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
        }

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }
        public DbSet<Cobranca>? Cobrancas { get; set; }
        public DbSet<ItemPedido>? ItensPedido { get; set; }
        public DbSet<Pedido>? Pedidos { get; set; }
    }
}
