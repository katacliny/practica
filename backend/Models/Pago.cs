using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Models
{
    [Table("Pagos")]
    public class Pago
    {
        [Key]
        public long IdPago { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public EstadoPago EstadoPago { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public Factura Factura { get; set; }

        //constructor
        public Pago() { }
        public Pago(long idPago, EstadoPago estadoPago, Factura factura)
        {
            this.IdPago = idPago;
            this.EstadoPago = estadoPago;
            this.Factura = factura;
        }

    }

    public enum EstadoPago
    {
        pendiente,
        aceptado, 
        fallido
    }
}
