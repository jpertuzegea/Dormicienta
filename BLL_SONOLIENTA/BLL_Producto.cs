using DAO_SONOLIENTA;
using DAO_SONOLIENTA.Enum;
using MODELOS_SONOLIENTA.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_SONOLIENTA
{
    public class BLL_Producto
    {
        private SONOLIENTAEntities bd = new SONOLIENTAEntities();


        public List<PRODUCTO> ListarProductos(EnumFiltroEstado Filtro) 
        {
            List<PRODUCTO> ListProducto = null;
            try
            {
                switch (Filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListProducto = bd.PRODUCTO.Where(c => c.Estado == (byte) EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListProducto = bd.PRODUCTO.Where(c => c.Estado == (byte) EnumEstados.Inactivo).ToList();
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
        public Producto GetProductoByProductoId(int ProductoId)
{
    try
    {
        Producto Producto = bd.Producto.Find(ProductoId);

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
public Boolean GuargarProducto(ProductoModel ProductoModel)
{
    if (ProductoModel != null)
    {// si el objeto es diferente de nulo
        try
        {
            AssemblersProducto AssemblersProducto = new AssemblersProducto();
            bd.Producto.Add(AssemblersProducto.de_modelo_a_entidad(ProductoModel));
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
public Boolean ModificarProducto(ProductoModel ProductoModel)
{
    Producto Producto = GetProductoByProductoId(ProductoModel.ProductoId);

    if (Producto != null)
    {
        try
        {
            Producto.Nombre = ProductoModel.Nombre;
            Producto.Descripcion = ProductoModel.Descripcion;
            Producto.Estado = ProductoModel.Estado;

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
