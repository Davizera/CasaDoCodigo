using CasaDoCodigo.Models;
using System;
using System.Linq;

namespace CasaDoCodigo.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(AplicationContext context) : base(context)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            var itemPedido = dbSet.Where(iP => iP.Id == itemPedidoId).SingleOrDefault();

            return itemPedido;
        }

        public void RemoveItemPedido(int itemPedidoId)
        {
            dbSet.Remove(GetItemPedido(itemPedidoId));
        }
    }
}
