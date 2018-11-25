using DemoPatron.Repository;
using System;
using Dapper;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using Npgsql;

namespace DemoPatron.RepositoryDapper
{
    public class RepositoryDapper<T> : IRepository<T> where T :class
    {
        
        public RepositoryDapper()
        {
            //
        }

        public IEnumerable<T> GetAll(string query)
        {
           
            using (var connection = new Factory())
            {
                return connection.connection.Query<T>(query).ToList();

              
            }
            
            
        }

       
    }
}
