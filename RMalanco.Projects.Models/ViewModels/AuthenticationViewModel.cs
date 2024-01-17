using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMalanco.Projects.Models.ViewModels
{
    public class AuthenticationViewModel
    {
        [Required(ErrorMessage = "El email es requerido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La contraseña es requerida")]
        public string? Password { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
