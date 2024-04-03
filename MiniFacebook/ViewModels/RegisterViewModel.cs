using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniFacebook.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(20)]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El apellido es obligatorio")]
        [StringLength(20)]
        public string Apellido { get; set; }
        [Required(ErrorMessage ="El email es obligatorio")]
        [EmailAddress]
        public string Email { get; set; }
        [Required (ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(20, MinimumLength = 6)]
        public string Contraseña { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 6)]
        [Compare("Contraseña")]
        public string ConfirmarContraseña { get; set; }

        public string Mensaje { get; set; }



    }
}