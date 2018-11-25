using DemoPatron.BLL;
using System;

namespace DemoPatron.ConsoleAppNC
{
    class Program
    {
        static void Main(string[] args)
        {
            var Categories = new CategoryManager().
               GetCategories();

            foreach (var category in Categories)
            {
                Console.WriteLine
                    ($"Id: {category.CategoryId}, Name:{category.CategoryName}");
            }
            Console.ReadLine();
        }
    }
}
