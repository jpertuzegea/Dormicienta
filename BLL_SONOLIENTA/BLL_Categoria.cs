﻿using DAO_SONOLIENTA;
using DAO_SONOLIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace BLL_SONOLIENTA
{
    public class BLL_Categoria
    {
        private SONOLIENTAEntities bd = new SONOLIENTAEntities();

        public List<CATEGORIA> ListarCategorias(EnumFiltroEstado Filtro)
        {
            List<CATEGORIA> ListCategorias = null;
            try
            {
                switch (Filtro)
                {
                    case EnumFiltroEstado.Activo://Activo
                        ListCategorias = bd.CATEGORIA.Where(c => c.Estado == (byte)EnumEstados.Activo).ToList();
                        break;

                    case EnumFiltroEstado.Inactivo://Inactivo
                        ListCategorias = bd.CATEGORIA.Where(c => c.Estado == (byte)EnumEstados.Inactivo).ToList();
                        break;

                    case EnumFiltroEstado.Todos:// Todos
                        ListCategorias = bd.CATEGORIA.ToList();
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
        public CATEGORIA GetCategoriaByCategoriaId(int CategoriaId)
        {
            try
            {
                CATEGORIA Categoria = bd.CATEGORIA.Find(CategoriaId);

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
        public Boolean GuargarCategoria(CATEGORIA CategoriaModel)
        {
            if (CategoriaModel != null)
            {// si el objeto es diferente de nulo
                try
                {
                    bd.CATEGORIA.Add(CategoriaModel);
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
        public Boolean ModificarCategoria(CATEGORIA CATEGORIA)
        {
            CATEGORIA Categoria = GetCategoriaByCategoriaId(CATEGORIA.CategoriaId);

            if (Categoria != null)
            {
                try
                {
                    Categoria.Nombre = CATEGORIA.Nombre;
                    Categoria.Descripcion = CATEGORIA.Descripcion;
                    Categoria.Imagen = CATEGORIA.Imagen;
                    Categoria.Estado = CATEGORIA.Estado;

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

        // Arma un select list de Categorias, con la propiedad value y name 
        public List<SelectListItem> ArmarSelectUsuarios(EnumFiltroEstado filtro)
        {
            List<CATEGORIA> Lista = null;
            Lista = ListarCategorias(filtro);

            List<SelectListItem> result = new List<SelectListItem>();// se debe importar la dll que esta en el proyecto vista
            foreach (var item in Lista)
            {
                var nombre = item.Nombre;
                var valor = item.CategoriaId;
                result.Add(new SelectListItem() { Text = nombre, Value = valor.ToString() });
            }
            return result;
        }
    }
}
