using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarritoCompra.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        //atributos
        [Key]
        public long IdUsuario { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(10)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Apellidos { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(40)]
        public string Direccion { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        [StringLength(15)]
        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public List<Pedido> ListaPedidos { get; set; }

        //constructor
        public Usuario() { }

        public Usuario(long idUsuario, string nombre, string apellidos, string direccion, 
                       string telefono, List<Pedido> pedidos)
        {
            this.IdUsuario = idUsuario;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.ListaPedidos = pedidos;
        }

    }
}
