using DemoPatron.Entities;
using DemoPatron.Repository;
using DemoPatron.RepositoryDapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoPatron.DAL
{
    public class CategoryDAL
    {
        
        private readonly IRepository<Category> repository;

        public CategoryDAL()
        {

            repository =
                new RepositoryDapper<Category>();
        }

        public List<Category> GetCategories()
        {
            var query = "SELECT * FROM \"T_Categories\"";
            return repository.GetAll(query).ToList();
        }
    }
}
