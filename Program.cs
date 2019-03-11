using Fuzzy_search_Demo.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fuzzy_search_Demo
{
    class Program
	{
        static void Main(string[] args)
        {
            List<string> l = new List<string>
            {
                "ant",
                "aunt",
                "Sam",
                "Samantha" ,
                "clozapine",
                "olanzapine" ,
                "annt",
                "volmax" ,
                "toradol",
                "at" ,
                "kitten",
                "sitting" 
            };

            Console.WriteLine("\n\n\n---------------------------------------------------------------");
            Console.WriteLine("All Items in List");
            foreach (string a in l)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("---------------------------------------------------------------");

            Console.WriteLine("\n\n\nEnter Search Term to search on the list");
            var searchTerm = Console.ReadLine();
             
            var searchedString = l.Where(x => searchTerm.IsFuzzySimilar(x, 2));


            Console.WriteLine("\n\n\n---------------------------------------------------------------");
            Console.WriteLine("Fuzzy search result is : ");
            foreach (var item in searchedString)
            {
                Console.WriteLine(item); 
            }

            Console.WriteLine("\n\n\n==========Enter any key to exit============");
            Console.ReadKey();   
        }

	} 
}