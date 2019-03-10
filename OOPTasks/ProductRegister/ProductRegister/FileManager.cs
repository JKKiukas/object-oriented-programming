using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProductRegister
{
    class FileManager
    {
        private readonly string _file;
        private List<Items> _itemsList;

        public FileManager(string _file)
        {
            this._file = _file;
        }

        public string SortItems()
        {
            string sortItems = string.Empty;
            try
            {
                sortItems = ReadFile();
                return sortItems;
            }

            catch(Exception exception)
            {
                return exception.Message;
            }
        }

        private string ReadFile()
        {
            if (File.Exists(_file))
            {
                _itemsList = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this._file));

                foreach (Items items in _itemsList)
                {                    
                    Console.WriteLine($"\nTuotteen nimi: {items.name}" +
                                      $"\nTuotteen numero: {items.id}" +
                                      $"\nTuoteryhmä: {items.groupName}");
                }

                Console.WriteLine("\nHaetaanko kaikki tiedot tuotteesta?");
                Console.WriteLine("[1] = Kyllä");
                Console.WriteLine("[2] = Ei\n");

                bool wrongInput = false;
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Write("\nSyötä tuotenumero: ");
                    string idInput = Console.ReadLine();

                    foreach (Items items in _itemsList)
                    {
                        if(idInput == items.id)
                        {
                            Console.WriteLine($"\nTuotteen nimi: {items.name}" +
                                              $"\nTuotteen numero: {items.id}" +
                                              $"\nTuoteryhmä: {items.groupName}" +
                                              $"\nTuotteen hinta: {items.price}" +
                                              $"\nTuotteita varastossa: {items.amount}" +
                                              $"\nKommentti tuotteesta: {items.comment}\n");

                            wrongInput = true;

                            Console.WriteLine("Paina ENTER-näppäintä palataksesi alkuun.");
                        }
                    }

                    if (!wrongInput)
                    {
                        Console.WriteLine("\nVirheellinen syöte.");
                        Console.WriteLine("\nPaina ENTER-näppäintä palataksesi alkuun.");
                    }
                }

                else
                {
                    Console.WriteLine("\nKaikkia tietoja ei näytetty, koska valitsit toiminnon 2 tai syöte oli virheellinen.");
                    Console.WriteLine("\nPaina ENTER-näppäintä palataksesi alkuun.");
                }
            }

            else if (!File.Exists(_file))
            {
                throw new Exception("Tiedostoa ei löytynyt.");
            }

            return "";
        }

        public string ArrangeProductGroup(string group)
        {
            _itemsList = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this._file));

            foreach (Items items in _itemsList)
            {
                if (group == "1")
                {
                    if(items.groupName == "Lajittelu ja säilytys")
                    {
                        Console.WriteLine($"\nTuotteen nimi: {items.name}" +
                                          $"\nTuotteen numero: {items.id}" +
                                          $"\nTuoteryhmä: {items.groupName}" +
                                          $"\nTuotteen hinta: {items.price}" +
                                          $"\nTuotteita varastossa: {items.amount}" +
                                          $"\nKommentti tuotteesta: {items.comment}\n");
                    }
                }

                else if (group == "2")
                {
                    if (items.groupName == "Paperit ja lehtiöt")
                    {
                        Console.WriteLine($"\nTuotteen nimi: {items.name}" +
                                          $"\nTuotteen numero: {items.id}" +
                                          $"\nTuoteryhmä: {items.groupName}" +
                                          $"\nTuotteen hinta: {items.price}" +
                                          $"\nTuotteita varastossa: {items.amount}" +
                                          $"\nKommentti tuotteesta: {items.comment}\n");
                    }
                }

                else if (group == "3")
                {
                    if (items.groupName == "Kynät")
                    {
                        Console.WriteLine($"\nTuotteen nimi: {items.name}" +
                                          $"\nTuotteen numero: {items.id}" +
                                          $"\nTuoteryhmä: {items.groupName}" +
                                          $"\nTuotteen hinta: {items.price}" +
                                          $"\nTuotteita varastossa: {items.amount}" +
                                          $"\nKommentti tuotteesta: {items.comment}\n");
                    }
                }

                else if (group == "4")
                {
                    if (items.groupName == "Kortit ja kirjekuoret")
                    {
                        Console.WriteLine($"\nTuotteen nimi: {items.name}" +
                                          $"\nTuotteen numero: {items.id}" +
                                          $"\nTuoteryhmä: {items.groupName}" +
                                          $"\nTuotteen hinta: {items.price}" +
                                          $"\nTuotteita varastossa: {items.amount}" +
                                          $"\nKommentti tuotteesta: {items.comment}\n");
                    }
                }
                
                else
                {
                    return "\nVirheellinen syöte.\n" +
                            "\nPaina ENTER-näppäintä palataksesi alkuun.";
                }
            }

            Console.WriteLine("Paina ENTER-näppäintä palataksesi alkuun.");
            return "";
        }

        public void PrintOutOfStock()
        {
            _itemsList = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this._file));

            foreach (Items items in _itemsList)
            {
                if (items.amount == 0)
                {
                    Console.WriteLine($"\nTuotteen nimi: {items.name}" +
                                      $"\nTuotteen numero: {items.id}" +
                                      $"\nTuoteryhmä: {items.groupName}" +
                                      $"\nTuotteen hinta: {items.price}" +
                                      $"\nTuotteita varastossa: {items.amount}" +
                                      $"\nKommentti tuotteesta: {items.comment}\n");
                }
            }

            Console.WriteLine("Paina ENTER-näppäintä palataksesi alkuun.");
        }

        public void AddRemoveComment()
        {
            Console.WriteLine();
            _itemsList = JsonConvert.DeserializeObject<List<Items>>(File.ReadAllText(this._file));

            int j = 0;
            foreach (Items items in _itemsList)
            {
                Console.WriteLine($"{j+1}. {items.name}");
                j++;
            }

            Console.Write("\nSyötä tuotteen nimi, johon haluat lisätä kommentin tai josta haluat poistaa kommentin: ");
            string commentItem = Console.ReadLine();
            Console.WriteLine();
            bool isFound = false;

            foreach (Items items in _itemsList)
            {
                if (items.name == commentItem)
                {
                    Console.WriteLine("Haluatko lisätä tuotteeseen kommentin vai poistaa kommentin?");
                    Console.WriteLine("[1] = Lisää kommentin.");
                    Console.WriteLine("[2] = Poistaa kommentin.\n");
                    string userInput = Console.ReadLine();
                    isFound = true;

                    if (userInput == "1")
                    {
                        Console.Write("\nSyötä kommenttisi: ");
                        string userComment = Console.ReadLine();

                        if (items.comment.Replace("   ", "") != userComment)
                        {
                            items.comment += userComment + "   ";
                            File.WriteAllText(_file, JsonConvert.SerializeObject(_itemsList));
                            Console.WriteLine("\nKommentin lisääminen onnistui.");
                            Console.WriteLine($"\nLisäsit kommentin: {userComment}");
                        }

                        else if(items.comment.Replace("   ", "") == userComment)
                        {
                            Console.WriteLine("\nKommentin lisääminen epäonnistui. Samaa kommenttia ei voi lisätä toista kertaa.");
                        }
                    }

                    else if (userInput == "2")
                    {
                        Console.WriteLine("\nKommentin poistaminen onnistui.");
                        Console.WriteLine($"\nSeuraava kommentti poistettiin: {items.comment}");
                        items.comment = "";
                        File.WriteAllText(_file, JsonConvert.SerializeObject(_itemsList));
                    }

                    else
                    {
                        Console.WriteLine("\nVirheellinen syöte.");
                    }
                }
            }
            
            if (!isFound)
            {
                Console.WriteLine("\nVirheellinen syöte.");
            }

            Console.WriteLine("\nPaina ENTER-näppäintä palataksesi alkuun.");
        }
    }
}