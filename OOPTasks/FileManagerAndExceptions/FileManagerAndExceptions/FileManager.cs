using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FileManagerAndExceptions
{
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {
        }
    }

    class FileManager
    {
        private readonly string _filePath;
        private List<Person> _personsList;

        public FileManager(string filePath)
        {
            this._filePath = filePath;
        }

        public string ReadWords()
        {
            string content = string.Empty;
            try
            {
                content = ReadFile();
            }

            catch
            {
                return "File was not found.";
            }

            return content;
        }

        private string ReadFile()
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(_filePath);
            string fileName = Path.GetFileName(_filePath);
            string fileExtension = Path.GetExtension(_filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(_filePath, Encoding.UTF8);
            return fileContent;
        }

        public void InsertJson()
        {
            try
            {
                StreamReader streamReader = new StreamReader(_filePath);
                string json = streamReader.ReadToEnd();
                _personsList = JsonConvert.DeserializeObject<List<Person>>(json);
                PrintJson();
            }

            catch(Exception exception)
            {
                Console.WriteLine($"Couldn't use the file, error that happened: {exception.Message}");
            }
        }

        public void PrintJson()
        {
            foreach(Person person in _personsList)
            {
                Console.WriteLine($"Person's name: {person.name}" +
                                  $"\nPerson's age: {person.age}" +
                                  $"\nPerson's city: {person.city}\n");
            }
        }
    }
}