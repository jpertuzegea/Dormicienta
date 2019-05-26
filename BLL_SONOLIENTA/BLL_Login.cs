using MODELOS_SONOLIENTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Login
    {

        public Boolean InicarSesion(UsuariosModel UsuariosModel) {

            usuarios usuario = bd.usuarios.Where(u => u.usuarioRed.ToUpper().Equals(Usuarios_Model.usuarioRed.ToUpper())
               &&
               u.clave.Equals(Usuarios_Model.clave) // se debe encriptar con RSA la clave ingresada y luego compararla
               &&
               u.estado == (byte)Enum_Estados.Activo).FirstOrDefault();

            if ((usuario != null))
            {
                System.Web.HttpContext.Current.Session["IdUsuarioSonolienta"] = usuario.usuariosID;
                System.Web.HttpContext.Current.Session["NombreUsuarioRed"] = usuario.usuarioRed;
               
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CerrarSesion() {
            System.Web.HttpContext.Current.Session["IdUsuarioSonolienta"] = null;
            System.Web.HttpContext.Current.Session["NombreUsuarioRed"] = null;

            System.Web.HttpContext.Current.Session.Abandon();// destruye los objetos de sesion existentes
            FormsAuthentication.SignOut();

        }

        // Metodo que valida si existe una sesion activa
        public static void VerificarSesionActiva()
        {
            String NombreUsuarioRed = (String)System.Web.HttpContext.Current.Session["NombreUsuarioRed"];// se captura la variable de sesion con la que se validara que el usuario este logueado 

            if (NombreUsuarioRed != null)// si se poden las 2 condiciones en el mismo if se explota porque la 2° siempre llega nula
            { // si esta condicion se cumple el usuario es dirigido al Login
                if (NombreUsuarioRed.Length < 3) // Se verifica que la sesion exista y que el nombre del usuario logueado sea mayor a 3 (numero minimo para un nombre [ana])
                {
                    System.Web.HttpContext.Current.Response.Redirect("/login");// si la sesion no existe, lo direcciona al login
                }
            }
            else
            {
                System.Web.HttpContext.Current.Response.Redirect("/login");// si la sesion no existe, lo direcciona al login
            }
        }
    }
}
