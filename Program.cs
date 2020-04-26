using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace UpdateJsonValueForYuuandmi
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products { Color = "Purple", Fruit = "Onions", Size = "" };

            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"C:\Users\Michael Crump\source\repos\UpdateJsonValueForYuuandmi\example.json", JsonConvert.SerializeObject(products));

            // serialize JSON directly to a file
            using (StreamWriter file = File.CreateText(@"C:\Users\Michael Crump\source\repos\UpdateJsonValueForYuuandmi\example.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, products);
            }
        }
    }
}
