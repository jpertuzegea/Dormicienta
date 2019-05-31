using DAO_SONOLIENTA;
using DAO_SONOLIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Producto
    {
        private Dormisienta_Entities bd = new Dormisienta_Entities();


        public List<PRODUCTO> ListarProductos(EnumFiltroEstado Filtro)
        {
            List<PRODUCTO> ListProducto = null;
            try
            {
                switch (Filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListProducto = bd.PRODUCTO.Where(c => c.Estado == (byte)EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListProducto = bd.PRODUCTO.Where(c => c.Estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListProducto = bd.PRODUCTO.ToList();
                        break;
                }
                return (ListProducto);// retorna una lista de entidades
            }
            catch (Exception error)
            {
                //bd.Dispose();// cierra la conexion de BD
                BLL_File.Escribir_Log(error.ToString());
                throw;
            }
        }

        // metodo para buscar una sola Producto por id
        public PRODUCTO GetProductoByProductoId(int ProductoId)
        {
            try
            {
                PRODUCTO Producto = bd.PRODUCTO.Find(ProductoId);

                if (Producto != null)
                {
                    return (Producto);
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

        // metodo para crear un Producto
        public Boolean GuargarProducto(PRODUCTO PRODUCTO)
        {
            if (PRODUCTO != null)
            {// si el objeto es diferente de nulo
                try
                {
                    bd.PRODUCTO.Add(PRODUCTO);
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

        // metodo para Modificar un Producto
        public Boolean ModificarProducto(PRODUCTO PRODUCTO)
        {
            PRODUCTO Producto = GetProductoByProductoId(PRODUCTO.ProductoId);

            if (Producto != null)
            {
                try
                {
                    Producto.Nombre = PRODUCTO.Nombre;
                    Producto.Descripcion = PRODUCTO.Descripcion;
                    Producto.Estado = PRODUCTO.Estado;

                    bd.Entry(Producto).State = EntityState.Modified;
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
