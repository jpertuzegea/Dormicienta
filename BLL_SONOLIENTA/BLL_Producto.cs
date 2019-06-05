using DAO_DORMISIENTA;
using DAO_DORMISIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL_DORMISIENTA
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
                        ListProducto = bd.PRODUCTO.Include(c => c.CATEGORIA).Where(c => c.Estado == (byte)EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListProducto = bd.PRODUCTO.Include(c => c.CATEGORIA).Where(c => c.Estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListProducto = bd.PRODUCTO.Include(c => c.CATEGORIA).ToList();
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
        public Boolean GuargarProducto(PRODUCTO Producto, HttpPostedFileBase file)
        {
            if (Producto != null)
            {// si el objeto es diferente de nulo
                try
                {
                    byte[] imagenData = null;
                    using (var FotoCategoria = new BinaryReader(file.InputStream))
                    {
                        imagenData = FotoCategoria.ReadBytes(file.ContentLength);
                    }
                    Producto.Imagen = imagenData;
                    Producto.ContetType = file.ContentType;

                    bd.PRODUCTO.Add(Producto);
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
        public Boolean ModificarProducto(PRODUCTO PRODUCTO, HttpPostedFileBase file)
        {
            PRODUCTO Producto = GetProductoByProductoId(PRODUCTO.ProductoId);

            if (Producto != null)
            {
                try
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        byte[] imagenData = null;
                        using (var FotoCategoria = new BinaryReader(file.InputStream))
                        {
                            imagenData = FotoCategoria.ReadBytes(file.ContentLength);
                        }
                        Producto.Imagen = imagenData;
                        Producto.ContetType = file.ContentType;
                    }

                    Producto.Nombre = PRODUCTO.Nombre;
                    Producto.Codigo = PRODUCTO.Codigo;
                    Producto.Descripcion = PRODUCTO.Descripcion;
                    Producto.Nombre = PRODUCTO.Nombre;
                    Producto.Precio = PRODUCTO.Precio;
                    Producto.Categotia = PRODUCTO.Categotia;
                    Producto.CantidadDisponible = PRODUCTO.CantidadDisponible;
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
