using CasaDoCodigo.Models;

namespace CasaDoCodigo
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(string codigo);
    }
}