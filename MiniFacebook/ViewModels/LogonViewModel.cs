using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniFacebook.ViewModels
{
    public class LogonViewModel
    {
        [Required]
        public string nombre { get; set; }
        [Required]
        public string contraseña { get; set; }
    }

}