using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Models
{
    [Table("Productos")]
    public class Producto
    {
        //Atributos
        [Key]
        public long IdProducto { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string Descripcion { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string Imagen { get; set; }
        [Required]
        [Column(TypeName = "float")]
        public float Precio { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Stock { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public List<Pedido> ListaPedidos { get; set; }

        //constructor
        public Producto() { }

        public Producto(long idProducto, string nombre, string descripcion, 
                        string imagen, float precio, int stock, List<Pedido> pedidos)
        {
            this.IdProducto = idProducto;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Imagen = imagen;
            this.Precio = precio;
            this.Stock = stock;
            this.ListaPedidos = pedidos;
        }

    }
}
