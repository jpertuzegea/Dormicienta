using DAO_SONOLIENTA;
using DAO_SONOLIENTA.Enum; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace BLL_SONOLIENTA
{
    public class BLL_Login
    {
        private SONOLIENTAEntities bd = new SONOLIENTAEntities();

        public Boolean InicarSesion(USUARIO USUARIO) {

            USUARIO usuario = bd.USUARIO.Where(u => u.UsuarioRed.ToUpper().Equals(USUARIO.UsuarioRed.ToUpper())
               &&
               u.Clave.Equals(USUARIO.Clave) // se debe encriptar con RSA la clave ingresada y luego compararla
               &&
               u.Estado == (byte)EnumEstados.Activo).FirstOrDefault();

            if ((usuario != null))
            {
                System.Web.HttpContext.Current.Session["IdUsuarioSonolienta"] = usuario.UsuarioId;
                System.Web.HttpContext.Current.Session["NombreUsuarioRed"] = usuario.UsuarioRed;
               
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
