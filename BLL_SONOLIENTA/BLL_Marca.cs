using MODELOS_SONOLIENTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Marca
    {
        public List<MarcaModel> ListarMarcas(EnumFiltroEstado Filtro)) 
        {
            List<Marca> ListMarca = null;
            try
            {
                switch (filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListMarca = bd.Marca.Where(c => c.estado == (byte)EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListMarca = bd.Marca.Where(c => c.estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListMarca = bd.Marca.ToList();
                        break;
                }
                return (ListMarca);// retorna una lista de entidades
            }
            catch (Exception error)
            {
                //bd.Dispose();// cierra la conexion de BD
                BLL_File.Escribir_Log(error.ToString());
                throw;
            }

        }

        // metodo para buscar una sola Marca por id
        public Marca GetMarcaByMarcaId(int MarcaId)
        {
            try
            {
        Marca Marca = bd.Marca.Find(MarcaId);

                if (Marca != null)
                {
                    return (Marca);
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
        public Boolean GuargarMarca(MarcaModel MarcaModel)
        {
            if (MarcaModel != null)
            {// si el objeto es diferente de nulo
                try
                {
                    AssemblersMarca AssemblersMarca = new AssemblersMarca();
                    bd.Marca.Add(AssemblersMarca.de_modelo_a_entidad(MarcaModel));
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
        public Boolean ModificarMarca(MarcaModel MarcaModel)
        {
            Marca Marca = GetMarcaByMarcaId(MarcaModel.MarcaId);

            if (Marca != null)
            {
                try
                {
                    Marca.Nombre = MarcaModel.Nombre;
                    Marca.Descripcion = MarcaModel.Descripcion;
                    Marca.Estado = MarcaModel.Estado;

                    bd.Entry(Marca).State = EntityState.Modified;
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
