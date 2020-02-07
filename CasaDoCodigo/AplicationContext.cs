using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().HasKey(produto => produto.Id);

            modelBuilder.Entity<Pedido>().HasKey(pedido => pedido.Id);
            modelBuilder.Entity<Pedido>().HasMany(pedido => pedido.Itens).WithOne(itemPedido => itemPedido.Pedido);
            modelBuilder.Entity<Pedido>().HasOne(pedido => pedido.Cadastro).WithOne(cadastro => cadastro.Pedido).IsRequired();


            modelBuilder.Entity<ItemPedido>().HasKey(itemPedido => itemPedido.Id);
            modelBuilder.Entity<ItemPedido>().HasOne(itemPedido => itemPedido.Produto);
            modelBuilder.Entity<ItemPedido>().HasOne(itemPedido => itemPedido.Pedido);

            modelBuilder.Entity<Cadastro>().HasKey(cadastro => cadastro.Id);
            modelBuilder.Entity<Cadastro>().HasOne(cadastro => cadastro.Pedido);
        }
    }
}
