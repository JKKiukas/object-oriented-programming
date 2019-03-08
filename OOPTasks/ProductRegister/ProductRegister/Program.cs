using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ProductRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Items items = new Items();
            FileManager fileManager = new FileManager();
            ConsoleKeyInfo cki;

            do
            {
                cki = SelectChoice();
                switch (cki.Key)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine(fileManager.SortItems());
                        break;

                    case ConsoleKey.F2:
                        Console.WriteLine("\nValitse tuoteryhmä.");
                        Console.WriteLine("\n1 = Lajittelu ja säilytys" +
                                          "\n2 = Paperit ja lehtiöt" +
                                          "\n3 = Kynät" +
                                          "\n4 = Kortit ja kirjekuoret");
                        Console.WriteLine();

                        string group = Console.ReadLine();
                        Console.WriteLine(fileManager.ArrangeProductGroup(group));
                        break;

                    case ConsoleKey.F3:
                        fileManager.PrintOutOfStock();
                        break;

                    case ConsoleKey.F4:
                        fileManager.AddRemoveComment();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("\nOhjelma suljetaan.");
                        Console.WriteLine("Paina ENTER-näppäintä jatkaaksesi.");
                        break;

                    default:
                        Console.WriteLine("Virheellinen syöte.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();

            }
            while (cki.Key != ConsoleKey.Escape);
        }

        static ConsoleKeyInfo SelectChoice()
        {
            Console.WriteLine("Tuoterekisteri\n" +
                              "\nValitse toiminto.");

            Console.WriteLine("\n[F1] = Toiminto listaa kaikki tuotteet." +
                              "\n[F2] = Toiminto listaa tuotteet ryhmittäin." +
                              "\n[F3] = Toiminto listaa loppuneet tuotteet." +
                              "\n[F4] = Toiminto lisää kommentin tuotteeseen tai poistaa kommentin tuotteesta." +
                              "\n[Esc] = Toiminto sulkee ohjelman.\n");

            return Console.ReadKey();
        }
    }
}