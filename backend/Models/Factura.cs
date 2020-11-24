using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Models
{
    [Table("Facturas")]
    public class Factura
    {
        //atributos
        [Key]
        public long IdFactura { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public float Precio { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public Pedido Pedido { get; set; }

        //constructores
        public Factura() { }

        public Factura(long idFactura, DateTime fecha, float precio, Pedido pedido)
        {
            this.IdFactura = idFactura;
            this.Fecha = fecha;
            this.Precio = precio;
            this.Pedido = pedido;
        }

    }
}
