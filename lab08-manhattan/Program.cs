using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using lab08_manhattan.classes;
using System.Collections.Generic;

namespace lab08_manhattan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            JsonConversion();
        }

        static void JsonConversion()
        {
            string path = "../../../../data.json";
            string text = "";

            using (StreamReader sr = File.OpenText(path))
            {
                text = sr.ReadToEnd();
            }
 
            Manhattan data = JsonConvert.DeserializeObject<Manhattan>(text);

            var boroughs = data.Features.Select(x=> x).Select(x=> x.Properties).Select(x=>x.Neighborhood);

            var allHoods = from hood in boroughs
                           select hood;

            Console.WriteLine("1. All neighborhoods in the data list: ");

            foreach (var item in allHoods)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("2. Filter neighborhoods with no name: ");

            var removeNoName = from hood in allHoods
                               where hood != ""
                               select hood;

            foreach (var item in removeNoName)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("2. Remove duplicate hoods: ");

            var removeDup = (from hood in allHoods
                             orderby hood
                             select hood).Distinct();

            foreach (var item in removeDup)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("3. Now all in one query: ");

            var singleQuery = (from hood in boroughs
                               orderby hood
                               where hood != ""
                               select hood).Distinct();

            foreach (var item in singleQuery)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("3. Now with a lambda: ");

            var lambda = allHoods.Where(hood => hood != "").Distinct().OrderBy(hood => hood);

            foreach (var item in lambda)
            {
                Console.WriteLine(item);
            }

        }
    }
}
