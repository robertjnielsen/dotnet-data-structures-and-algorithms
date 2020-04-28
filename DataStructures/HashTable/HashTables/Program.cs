using System;
using HashTables.Classes;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HashTable table = new HashTable(1024);

            table.Add("soup", "tomato");

            var value = table.Get("soup");

            Console.WriteLine(value);

            var exists = table.Contains("soup");

            System.Console.WriteLine($"Does it exist?  {exists}");
        }
    }
}
