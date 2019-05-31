using DAO_SONOLIENTA;
using DAO_SONOLIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace BLL_SONOLIENTA
{
    public class BLL_Usuario
    {
        private Dormisienta_Entities bd = new Dormisienta_Entities();

        // metodo para listar los Usuarios existentes
        public List<USUARIO> ListUsuarios(EnumFiltroEstado Filtro)
        {
            try
            {
                List<USUARIO> ListUsuarios = null;

                switch (Filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListUsuarios = bd.USUARIO.Where(c => c.Estado == (byte)EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListUsuarios = bd.USUARIO.Where(c => c.Estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListUsuarios = bd.USUARIO.ToList();
                        break;
                }

                return (ListUsuarios);// retorna una lista de entidades
            }
            catch (Exception error)
            {
                //bd.Dispose();// cierra la conexion de BD
                BLL_File.Escribir_Log(error.ToString());
                throw;
            }
        }

        // metodo para buscar un solo Usuario por id
        public USUARIO GetUsuarioByUsuarioId(int UsuarioId)
        {
            try
            {
                USUARIO usuario = bd.USUARIO.Find(UsuarioId);
                //bd.Dispose();// cierra la conexion de BD

                if (usuario != null)
                {
                    return (usuario);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception error)
            {
                //bd.Dispose();// cierra la conexion de BD
                BLL_File.Escribir_Log(error.ToString());
                throw;
            }
        }

        // metodo para crear un Usuario
        public Boolean GuardarUsuario(USUARIO USUARIO)                     
        {
            if (USUARIO != null)
            {// si el objeto es diferente de nulo
                try
                {
                    USUARIO.UsuarioRed = ArmarUsuaroRed(USUARIO.NombreCompleto); // se crea el usuario de red
                    USUARIO.FechaRegistro = DateTime.Parse(DateTime.Now.ToString("dd/MMM/yyyy HH:mm:ss"));
                    USUARIO.UsuarioRegistra = (int)System.Web.HttpContext.Current.Session["IdUsuarioSonolienta"];

                    bd.USUARIO.Add(USUARIO);
                    bd.SaveChanges();

                    return true;
                }
                catch (Exception Error)
                {
                    BLL_File.Escribir_Log(Error.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
                      
        // metodo para Modificar un Usuario
        public Boolean ModificarUsuario(USUARIO USUARIO)
        {
            USUARIO usuarios = GetUsuarioByUsuarioId(USUARIO.UsuarioId);

            if (usuarios != null)
            {
                try
                {
                    usuarios.NombreCompleto = USUARIO.NombreCompleto;
                    usuarios.Clave = USUARIO.Clave;
                    usuarios.Estado = USUARIO.Estado;
                    usuarios.Telefono = USUARIO.Telefono;
                    usuarios.Cedula = USUARIO.Cedula;

                    //usuarios.UsuarioRed = Usuarios_Model.UsuarioRed;// Usuario red nunca se cambia
                    // usuarios.FechaRegistro = USUARIO.FechaRegistro;
                    // usuarios.UsuarioRegistra = USUARIO.UsuarioRegistra;

                    bd.Entry(usuarios).State = EntityState.Modified;
                    bd.SaveChanges();

                    return true;
                }
                catch (Exception error)
                {
                    BLL_File.Escribir_Log(error.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        // Arma un select list de Usuarios, con la propiedad value y name 
        public List<SelectListItem> ArmarSelectUsuarios(EnumFiltroEstado filtro)
        {
            List<USUARIO> Lista = Lista = ListUsuarios(filtro);

            List<SelectListItem> result = new List<SelectListItem>();// se debe importar la dll que esta en el proyecto vista
            foreach (var item in Lista)
            {
                var nombre = item.NombreCompleto;
                var valor = item.UsuarioId;
                result.Add(new SelectListItem() { Text = nombre, Value = valor.ToString() });
            }
            return result;
        }

        // Metodo para validar si el usuarioRed existe ya registrado en la BD
        public Boolean ExisteUsuarioRed(String usuariored)
        {
            // si existe en la bd, se envia true y no se puede volvera utilizar este usuarioRed 
            // de lo contrario se envia false y  si se puede continuar con el guardado 
            Boolean usuario = bd.USUARIO.Count(e => e.UsuarioRed.ToUpper() == usuariored.ToUpper()) > 0;
            return usuario;
        }

        // metodo para armar el usuario de red, que nunca se debe modificar y dede ser unico
        public string ArmarUsuaroRed(string nombreCompleto)
        {
            var palabras = nombreCompleto.Split(' ');
            string usuarioRedBase = palabras[0].Substring(0, 1) + palabras[2]; // primera letra del nombre + primer apellido
            string usuarioRed = usuarioRedBase;// en caso que exista se va modificando este nuevo a partir del base y no del que ya se ha tocado

            int sumador = 1;

            while (ExisteUsuarioRed(usuarioRed) == true)// mientras que el usuarioRed exista aumentele 1 al usuario base
            {
                usuarioRed = usuarioRedBase + sumador;
                sumador = sumador + 1;
            }
            return usuarioRed;
        }


    }
}