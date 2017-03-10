using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProduktLibrary;

namespace Baza_Produktow
{
    class Program
    {
        List<Produkt> produkty = new List<Produkt>();       //Tworzy liste produktow

        private static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n****\tZARZĄDZANIE MAGAZYNEM\t****");
            Console.WriteLine(" 1. Dodaj Produkt");
            Console.WriteLine(" 2. Sprawdź Stan");
            Console.WriteLine(" 3. Znajdź Produkt");
            Console.WriteLine(" 4. Zmień ilość produktu");
            Console.WriteLine(" 5. Zmień cenę produktu");
            Console.WriteLine(" 6. Zmień nazwę produktu");
            Console.WriteLine(" 0. Koniec Progamu");
        }

        private static int WyborOpcji()
        {
            int wybor = 0;
            string str_wybor;
            bool good = false;

            while (good == false)
            {
                try
                {
                    Console.Write(" Wybór: ");
                    str_wybor = Console.ReadLine();
                    wybor = Convert.ToInt32(str_wybor); ;
                    good = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nPodaj Liczbę!");
                    good = false;
                }
            }
            return wybor;
        }

        private void DodajProdukt()
        {
            bool good = false;

            while (good == false)
            {
                try
                {
                    float a, b;
                    Console.Write("\nPodaj nazwę produktu: ");
                    string naz = Console.ReadLine();

                    Console.Write("Podaj cenę produktu: ");
                    string cen = Console.ReadLine();
                    a = Convert.ToSingle(cen);

                    Console.Write("Podaj ilość produktu: ");
                    string ilo = Console.ReadLine();
                    b = Convert.ToSingle(ilo);

                    produkty.Add(new Produkt { Nazwa = naz, Cena = a, Ilosc = b });
                    good = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nPodaj Poprawną Cenę lub Ilość produktu!");
                    good = false;
                }
            }
            Console.WriteLine("\nZapisano Produkt!\n");
            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
            Console.ReadLine();
            Console.Clear();
        }

        private void WyswietlProdukty()
        {
            foreach (Produkt elementy in produkty)
            {
                Console.Write("\nProdukt:{0,30}\n", elementy.Nazwa);
                Console.Write("Cena:{0,33}\n", elementy.Cena);
                Console.Write("Ilość:{0,32}\n\n", elementy.Ilosc);
            }
            Console.WriteLine("\nProdukty Znalezione: {0}\n", produkty.Count);
            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
            Console.ReadLine();
            Console.Clear();
        }

        private void SzukajProduktu()
        {
            Console.Write("Wprowadź nazwę produktu: ");
            string nazwap = Console.ReadLine();

            bool znaleziono = false;

            foreach (Produkt elementy in produkty)
            {
                if (elementy.Nazwa.Equals(nazwap))
                {
                    Console.Write("\nProdukt:{0,30}\n", elementy.Nazwa);
                    Console.Write("Cena:{0,33}\n", elementy.Cena);
                    Console.Write("Ilość:{0,32}\n\n", elementy.Ilosc);
                    Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                    Console.ReadLine();
                    Console.Clear();
                    znaleziono = true;
                }
            }

            if (znaleziono == false)
            {
                Console.WriteLine("\nNieznany produkt.\n");
                Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                Console.ReadLine();
                Console.Clear();
            }
            znaleziono = false;
        }

        private void ZmianaIlosciProduktu()
        {
            bool good = false;

            while (good == false)
            {
                Console.Write("Wprowadź nazwę produktu: ");
                string nazwap = Console.ReadLine();

                bool znaleziono = false;

                foreach (Produkt elementy in produkty)
                {
                    try
                    {
                        if (elementy.Nazwa.Equals(nazwap))
                        {
                            Console.WriteLine("\nIlość zapamiętana: {0,13}\n", elementy.Ilosc);
                            Console.Write("Wprowadź obecny stan ilościowy: ");
                            string nil = Console.ReadLine();
                            elementy.Ilosc = Convert.ToSingle(nil);

                            Console.WriteLine("\nZmieniono ilość!\n");
                            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                            Console.ReadLine();
                            Console.Clear();

                            znaleziono = true;
                            good = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nWprowadzono Błędne Dane!");
                        Console.ReadLine();
                        good = false;
                    }

                }

                if (znaleziono == false)
                {
                    Console.WriteLine("\nNieznany produkt.\n");
                    Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                znaleziono = false;
            }
        }

        private void ZmianaCenyProduktu()
        {
            bool good = false;

            while (good == false)
            {
                Console.Write("Wprowadź nazwę produktu: ");
                string nazwap = Console.ReadLine();

                bool znaleziono = false;

                foreach (Produkt elementy in produkty)
                {
                    try
                    {
                        if (elementy.Nazwa.Equals(nazwap))
                        {
                            Console.WriteLine("\nCena zapamiętana: {0,13}\n", elementy.Cena);
                            Console.Write("Wprowadź nową cenę produktu: ");
                            string nil = Console.ReadLine();
                            elementy.Cena = Convert.ToSingle(nil);

                            Console.WriteLine("\nZmieniono Cenę!\n");
                            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                            Console.ReadLine();
                            Console.Clear();

                            znaleziono = true;
                            good = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nWprowadzono Błędne Dane!");
                        Console.ReadLine();
                        good = false;
                    }

                }

                if (znaleziono == false)
                {
                    Console.WriteLine("\nNieznany produkt.\n");
                    Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                znaleziono = false;
            }
        }

        private void ZmianaNazwyProduktu()
        {
            bool good = false;

            while (good == false)
            {
                Console.Write("Wprowadź nazwę produktu: ");
                string nazwap = Console.ReadLine();

                bool znaleziono = false;

                foreach (Produkt elementy in produkty)
                {
                    try
                    {
                        if (elementy.Nazwa.Equals(nazwap))
                        {
                            Console.WriteLine("\nCena zapamiętana: {0,13}\n", elementy.Nazwa);
                            Console.Write("Wprowadź nową nazwę produktu: ");
                            string nil = Console.ReadLine();
                            elementy.Nazwa = nil;

                            Console.WriteLine("\nZmieniono Nazwę!\n");
                            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                            Console.ReadLine();
                            Console.Clear();

                            znaleziono = true;
                            good = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nWprowadzono Błędne Dane!");
                        Console.ReadLine();
                        good = false;
                    }

                }

                if (znaleziono == false)
                {
                    Console.WriteLine("\nNieznany produkt.\n");
                    Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                    Console.ReadLine();
                    Console.Clear();
                }
                znaleziono = false;
            }
        }

        static void Main(string[] args)     // MAIN 
        {
            Program Instancja = new Program();
            bool run = true;

            while (run == true)
            {
                ShowMenu();

                switch (WyborOpcji())
                {
                    case 1:
                        Instancja.DodajProdukt();
                        break;

                    case 2:
                        Instancja.WyswietlProdukty();
                        break;

                    case 3:
                        Instancja.SzukajProduktu();
                        break;

                    case 4:
                        Instancja.ZmianaIlosciProduktu();
                        break;

                    case 5:
                        Instancja.ZmianaCenyProduktu();
                        break;

                    case 6:
                        Instancja.ZmianaNazwyProduktu();
                        break;

                    case 0:
                        run = false;
                        Console.WriteLine("\nKoniec Programu.");
                        Console.Read();
                        break;

                    default:
                        Console.WriteLine("Nie ma takiego knefla!\n");
                        break;
                }
            }

        }
    }
}


