using ConsoleApp11.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    public class PrintResult
    {
        public static void Print(Result results)
        {
            string str1 = String.Format("| {0,-25} | {1,-25} |",
                    "Product",
                    "Category");
            Console.WriteLine(str1);
            Console.WriteLine("---------------------------------------------------------");
            foreach (var item in results.Products)
            {
                string str = String.Format("| {0,-25} | {1,-25} |",                   
                    item.Name,
                    results.Categories.Where(c=>c.Id==item.CategoryId).ToList().FirstOrDefault().Name);
                Console.WriteLine(str);
            }
        }
    }
}
