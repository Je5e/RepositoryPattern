using DemoPatron.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPatron.TestConsoloAppNF
{
    class Program
    {
        static void Main(string[] args)
        {
            var Categories = new CategoryManager().
                GetCategories();
            int result = 0;

            while (result != 1)
            {
                foreach (var category in new CategoryManager().GetCategories())
                {
                    Console.WriteLine
                        ($"Id: {category.CategoryId}, Name:{category.CategoryName}");
                }
                Console.WriteLine("Ingrese 1 para salir.");
                result = int.Parse(Console.ReadLine());

            }


        }
    }
}
