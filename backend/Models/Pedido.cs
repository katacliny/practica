using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        //atributos
        [Key]
        public long IdPedido { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public float PrecioTotal { get; set; }
        [Required]
        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public List<Producto> ListaProductos { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public Usuario Usuario { get; set; }

        //constructor
        public Pedido() { }

        public Pedido(long idPedido, float precioTotal, DateTime fecha, List<Producto> productos, Usuario usuario)
        {
            this.IdPedido = idPedido;
            this.PrecioTotal = precioTotal;
            this.Fecha = fecha;
            this.ListaProductos = productos;
            this.Usuario = usuario;
        }
    }
}
