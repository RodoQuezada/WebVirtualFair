using System;
using System.ComponentModel.DataAnnotations;

namespace WebVirtualFair.Models
{
    public class ProductData
    {
        public long id { get; set; }
       [Required(ErrorMessage = "Debe Ingresar Nombre del Producto")]
        public string name { get; set; }
        [Required(ErrorMessage = "Debe Ingresar Descripción del Producto")]
        public string description { get; set; }
        [Required(ErrorMessage = "Debe Ingresar Imagen del Producto")]
        public string image { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        
        
    }
}