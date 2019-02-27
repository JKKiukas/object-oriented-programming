using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FileManagerAndExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = string.Empty;

            Console.WriteLine("Reading Persons.txt file.\n");
            FileManager fileManager = new FileManager(@"C:\temp\Persons.txt");
            Console.WriteLine(fileManager.ReadWords());
            Console.WriteLine();

            Console.WriteLine("\nReading Persons.json file.\n");
            FileManager fileManagerJson = new FileManager(@"C:\temp\Persons.json");
            fileManagerJson.InsertJson();

            Console.WriteLine("\nTrying to read a file which doesn't exist.");
            FileManager file = new FileManager(filePath);
            Console.WriteLine(file.ReadWords());
            Console.WriteLine();
        }
    }
}