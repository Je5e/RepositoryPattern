using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPatron.Repository
{
   public interface IRepository<T> where T: class
    { 
        // int es un tipo valor, clases son tipos refr. string is ref
        IEnumerable<T> GetAll(string query);

       
    }
}
