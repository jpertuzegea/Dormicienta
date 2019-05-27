using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Usuario
    {

        // metodo para listar los Usuarios existentes
        public List<Usuario> ListUsuarios(EnumFiltroEstado Filtro)
        {
            try
            {
                List<USUARIO> ListUsuarios = null;

                switch (filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListUsuarios = bd.Usuario.Where(c => c.estado == (byte)EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListUsuarios = bd.Usuario.Where(c => c.estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListUsuarios = bd.Usuario.ToList();
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
        public Usuario GetUsuarioByUsuarioId(int UsuarioId)
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
        public Boolean GuargarUsuario(UsuarioModel UsuarioModel)
        {
            if (UsuarioModel != null)
            {// si el objeto es diferente de nulo
                try
                {  
                    UsuariosModel.usuarioRed = ArmarUsuaroRed(UsuarioModel.nombreCompleto); // se crea el usuario de red
                    AssemblersUsuarios AssemblersUsuarios = new AssemblersUsuarios();
                    bd.usuarios.Add(AssemblersUsuarios.de_modelo_a_entidad(UsuariosModel));
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
        public Boolean ModificarUsuario(UsuarioModel UsuarioModel)
        {
            usuario  usuarios = GetUsuarioByUsuarioId(UsuarioModel.UsuarioId);

            if (usuarios != null)
            {
                try
                {
                   
                    usuarios.NombreCompleto = UsuarioModel.NombreCompleto;
                    //usuarios.UsuarioRed = Usuarios_Model.UsuarioRed;// Usuario red nunca se cambia
                    usuarios.Clave = UsuarioModel.Clave;
                    usuarios.Estado = UsuarioModel.Estado;
                    usuarios.Telefono = UsuarioModel.Telefono;

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
            Assemblers_Usuarios Assemblers_Usuarios = new Assemblers_Usuarios();
            List<UsuariosModel> Lista = null;

            switch (filtro)
            {
                case EnumFiltroEstado.Activo://Activo
                    Lista = Assemblers_Usuarios.List_de_entidades_a_modelos(ListUsuarios().Where(c => c.estado == (byte)EnumEstados.Activo).ToList());
                    break;

                case EnumFiltroEstado.Inactivo://Inactivo
                    Lista = Assemblers_Usuarios.List_de_entidades_a_modelos(ListUsuarios().Where(c => c.estado == (byte)EnumEstados.Inactivo).ToList());
                    break;

                case EnumFiltroEstado.Todos:// Todos
                    Lista = Assemblers_Usuarios.List_de_entidades_a_modelos(ListUsuarios());
                    break;
            }

            List<SelectListItem> result = new List<SelectListItem>();// se debe importar la dll que esta en el proyecto vista
            foreach (var item in Lista)
            {
                var nombre = item.nombre_completo;
                var valor = item.usuariosID;
                result.Add(new SelectListItem() { Text = nombre, Value = valor.ToString() });
            }
            return result;
        }
              
        // Metodo para validar si el usuarioRed existe ya registrado en la BD
        public Boolean ExisteUsuarioRed(String usuariored)
        {
            // si existe en la bd, se envia true y no se puede volvera utilizar este usuarioRed 
            // de lo contrario se envia false y  si se puede continuar con el guardado 
            Boolean usuario = bd.usuarios.Count(e => e.usuarioRed.ToUpper() == usuariored.ToUpper()) > 0;
            return usuario;
        }

        // metodo para armar el usuario de red, que nunca se debe modificar y dede ser unico
        public string ArmarUsuaroRed(string nombreCompleto)
        {
            var palabras = nombreCompleto.Split(' ');
            string usuarioRedBase = palabras[0].Substring(0, 1) + palabras[2]; // primera letra del nombre + primer apellido
            string usuarioRed = usuarioRedBase;// en caso que exista se va modificando este nuevo a partir del base y no del que ya se ha tocado

            int sumador = 1;

            while (Existe_UsuarioRed(usuarioRed) == true)// mientras que el usuarioRed exista aumentele 1 al usuario base
            {
                usuarioRed = usuarioRedBase + sumador;
                sumador = sumador + 1;
            }
            return usuarioRed;
        }


    }
}