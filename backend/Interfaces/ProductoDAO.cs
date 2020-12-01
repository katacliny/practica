using CarritoCompra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Interfaces
{
    interface ProductoDAO
    {
        Producto crearProducto(long idProducto, string nombre, string imagen, string descripcion, 
                               float precio, int stock);

        void eliminarProducto(long idProducto);

        List<Producto> anhadirAlCarrito(Producto producto);

    }
}
