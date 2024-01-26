using System.ComponentModel.DataAnnotations;

namespace CrudNet7MVC.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El precio es obligatorio")]
        public double Precio { get; set; }
    }
}
