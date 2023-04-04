using System;
using System.Collections.Generic;

namespace ZarzadzanieNotatkami
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> notatki = new List<string>();

            while (true)
            {
                Console.WriteLine("Wybierz opcję: ");
                Console.WriteLine("1. Dodaj notatkę");
                Console.WriteLine("2. Wyświetl notatki");
                Console.WriteLine("3. Usuń notatkę");
                Console.WriteLine("4. Wyjście");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Console.WriteLine("Wpisz swoją notatkę:");
                        string nowaNotatka = Console.ReadLine();
                        notatki.Add(nowaNotatka);
                        Console.WriteLine("Notatka dodana.");
                        break;

                    case "2":
                        if (notatki.Count == 0)
                        {
                            Console.WriteLine("Brak notatek.");
                        }
                        else
                        {
                            Console.WriteLine("Twoje notatki:");
                            for (int i = 0; i < notatki.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + notatki[i]);
                            }
                        }
                        break;

                    case "3":
                        if (notatki.Count == 0)
                        {
                            Console.WriteLine("Brak notatek.");
                        }
                        else
                        {
                            Console.WriteLine("Którą notatkę chcesz usunąć? Wpisz numer notatki:");
                            int numerNotatki = int.Parse(Console.ReadLine());
                            if (numerNotatki <= notatki.Count)
                            {
                                notatki.RemoveAt(numerNotatki - 1);
                                Console.WriteLine("Notatka usunięta.");
                            }
                            else
                            {
                                Console.WriteLine("Nieprawidłowy numer notatki.");
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("Koniec programu.");
                        return;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
