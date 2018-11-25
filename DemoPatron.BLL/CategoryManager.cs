using DemoPatron.DAL;
using DemoPatron.Entities;
using DemoPatron.Repository;
using System;
using System.Collections.Generic;

namespace DemoPatron.BLL
{
    public class CategoryManager
    {
        private readonly CategoryDAL DAL;
        public CategoryManager()
        {
            DAL = new CategoryDAL();
        }

        public List<Category> GetCategories()
        {
            
            // Lógica de negocio:
           // if PRODUCTO.INVENTARIO == 0 NO ELIMINAR
           // IF PRODUCTO.NAME == NEWNAME THEN NO GUARDAR

            return DAL.GetCategories();
        }
    }
}
