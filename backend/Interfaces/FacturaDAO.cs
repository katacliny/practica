using CarritoCompra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Interfaces
{
    interface FacturaDAO
    {
        FacturaDAO crearFactura(long idFactura, Pedido pedido, float precio, DateTime fecha);
        void eliminarFactura(long idFactura);
    }
}
