using CarritoCompra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Interfaces
{
    interface PedidoDAO
    {
        Pedido crearPedido(long idPedido, Usuario usuario, DateTime fecha, List<Producto> listaProductos);
        void eliminarPedido(long idPedido);
        void actualizarPedido(long idPedido, Usuario usuario, DateTime fecha, List<Producto> listaProductos);
        Pedido getPedidoById(long idPedido);
        float aplicarDescuento(float precioPedido);
    }
}
