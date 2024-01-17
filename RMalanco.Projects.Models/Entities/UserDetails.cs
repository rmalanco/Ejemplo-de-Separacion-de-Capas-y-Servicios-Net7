using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Models.Entities
{
    public class UserDetails
    {
        [Key]
        public int IdUserDetail { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }
        public string? CodigoPostal { get; set; }
    }
}
