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

            // using streamreader to access the file. 
            using (StreamReader sr = File.OpenText(path))
            {
                // get all the text
                text = sr.ReadToEnd();
            }
 
            Manhattan hoods = JsonConvert.DeserializeObject<Manhattan>(text);

            Console.WriteLine("I see you");

            // Lambda expression to get all the quotes from 
            // Dr. Seuss.
            //var drSeuss = myQuotes.Where(x => x.Author == "Dr. Seuss");

            //foreach (var item in drSeuss)
            //{
            //    if (item.Author == "Dr. Seuss")
            //    {
            //        Console.WriteLine(item.Text);
            //    }
            //}


        }
    }
}
