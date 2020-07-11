using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using DAO_SONOLIENTA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DORMISIENTA
{
    public class BLL_Marca
    {
        private Dormisienta_Entities bd = new Dormisienta_Entities();

        public List<MARCA> ListarMarcas(EnumFiltroEstado Filtro)
        {
            List<MARCA> ListMarca = null;
            try
            {
                switch (Filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListMarca = bd.MARCA.Where(c => c.Estado == (byte)EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListMarca = bd.MARCA.Where(c => c.Estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListMarca = bd.MARCA.ToList();
                        break;
                }
                return (ListMarca);// retorna una lista de entidades
            }
            catch (Exception error)
            {
                //bd.Dispose();// cierra la conexion de BD
                BLL_File.Escribir_Log(error.ToString());
                return null;
            }
        }

        // metodo para buscar una sola Marca por id
        public MARCA GetMarcaByMarcaId(int MarcaId)
        {
            try
            {
                MARCA Marca = bd.MARCA.Find(MarcaId);

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
                return null;
            }
        }

        // metodo para crear una Marca
        public bool GuargarMarca(MARCA MARCA)
        {
            if (MARCA != null)
            {// si el objeto es diferente de nulo
                try
                {
                    bd.MARCA.Add(MARCA);
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
        public bool ModificarMarca(MARCA MARCA)
        {
            MARCA Marca = GetMarcaByMarcaId(MARCA.MarcaId);

            if (Marca != null)
            {
                try
                {
                    Marca.Nombre = MARCA.Nombre;
                    Marca.Descripcion = MARCA.Descripcion;
                    Marca.Estado = MARCA.Estado;

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
