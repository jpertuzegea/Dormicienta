using MODELOS_SONOLIENTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Categoria
    {
        public List<CategoriaModel> ListarCategorias(EnumFiltroEstado Filtro)
        {
            List<Categoria> ListCategorias = null;
            try
            {
                switch (filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListCategorias = bd.Categoria.Where(c => c.estado == (byte)EnumEstados.Activo).ToList(); 
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListCategorias = bd.Categoria.Where(c => c.estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListCategorias = bd.Categoria.ToList() ;
                        break;
                } 
                return (ListCategorias);// retorna una lista de entidades
            }
            catch (Exception error)
            {
                //bd.Dispose();// cierra la conexion de BD
                BLL_File.Escribir_Log(error.ToString());
                throw;
            }

        }
 
        // metodo para buscar un solo Usuario por id
        public Categoria GetCategoriaByCatewgoriaId(int CategoriaId)
        {
            try
            {
                Categoria Categoria = bd.Categoria.Find(CategoriaId);
               
                if (Categoria != null)
                {
                    return (Categoria);
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
        public Boolean GuargarCategoria(CategoriaModel CategoriaModel)
        {
            if (CategoriaModel != null)
            {// si el objeto es diferente de nulo
                try
                { 
                    AssemblersCategoria AssemblersCategoria = new AssemblersCategoria();
                    bd.Categoria.Add(AssemblersCategoria.de_modelo_a_entidad(CategoriaModel));
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
        public Boolean ModificarCategoria(CategoriaModel CategoriaModel)
        {
            Categoria Categoria = GetCategoriaByCategoriaId(CategoriaModel.CategoriaId);

            if (Categoria != null)
            {
                try
                {  
                    Categoria.Nombre = CategoriaModel.Nombre;
                    Categoria.Descripcion = CategoriaModel.Descripcion;
                    Categoria.Imagen = CategoriaModel.Imagen;
                    Categoria.Estado = CategoriaModel.Estado;

                    bd.Entry(Categoria).State = EntityState.Modified;
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
         

    }
}
