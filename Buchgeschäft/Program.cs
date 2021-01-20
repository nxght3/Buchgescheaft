using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksLib;

namespace Buchgeschäft
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Item> liste = new List<Item>();
            liste.Add(new Newspaper(2m, 10, "Der Standard", DateTime.Parse("20.10.2020")));
            liste.Add(new Book(1.0m, 20, "The Malta Exchange", "Steve Berry", "189024891", Category.Thriller));
            liste.Add(new AudioBook(2.0m, 200, "Alea Aquarius 6: Der Fluss des Vergessens", "Tanya Stewner", "101283912", 536, Category.Thriller));

            foreach (var item in liste)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
