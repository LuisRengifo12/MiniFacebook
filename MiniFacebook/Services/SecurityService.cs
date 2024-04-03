using MiniFacebook.Models;
using MiniFacebook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniFacebook.Services
{
    public class SecurityService : ISecurityService
    {
        private USUARIOSEntities _context = null;
        public SecurityService()
        {
            _context = new USUARIOSEntities();
        }

        public void SaveUserToDB(RegisterViewModel model)
        {
            DetallesUsuario detallesUsuario = new DetallesUsuario();
            detallesUsuario.Email = model.Email;
            detallesUsuario.Nombre = model.Nombre;
            detallesUsuario.Apellido = model.Apellido;
            detallesUsuario.Contraseña = model.Contraseña;

            _context.DetallesUsuario.Add(detallesUsuario);
            _context.SaveChanges();
        }
        public bool IsValidUser (LogonViewModel model)
        {
            DetallesUsuario usuario = null;
            usuario = _context.DetallesUsuario.SingleOrDefault(C => C.Email.Equals(model.nombre)&& C.Contraseña.Equals(model.contraseña));
            if(usuario == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}

namespace MiniFacebook
{
    public interface ISecurityService
    {
        void SaveUserToDB(RegisterViewModel model);
        bool IsValidUser(LogonViewModel model);
    }
}