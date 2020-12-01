using CarritoCompra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Interfaces
{
    interface UsuarioDAO
    {
       Usuario crearUsuario(long idUsuario, string nombre, string direccion, string telefono, List<Pedido> listaPedidos);
       void eliminarUsuario(long idUsuario);
        void actualizarUsuario(long idUsuario, string nombre, string direccion, string telefono, List<Pedido> listaPedidos);


    }
}
