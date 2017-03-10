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
            Console.WriteLine("****\tZARZĄDZANIE MAGAZYNEM\t****");
            Console.WriteLine(" 1. Dodaj Produkt");
            Console.WriteLine(" 2. Sprawdź Stan");
            Console.WriteLine(" 3. Znajdź Produkt");
            Console.WriteLine(" 4. Zmień ilość produktu");
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
        }   // Non static???

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
        } // Non static??? :(



        static void Main(string[] args)
        {

            ShowMenu();

            switch (WyborOpcji())
            {
                case 1:

                    break;

                default:
                    Console.WriteLine("Nie ma takiego knefla!");
                    break;
            }


        }

        /*
            while (true)
            {
                
                // kOMENT
                switch (wybor)
                {
                    case 1:  // Dodawanie produktu
                        {

        
                            break;
                        }
                    case 2: // Wyswietlanie listy produktow
                        {
                            foreach (Produkt elementy in list)
                            {
                                elementy.Wyswietl();

                            }
                            Console.WriteLine("\nProdukty Znalezione: {0}\n", list.Count);
                            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case 3: // szukanie produktu
                        {
                            Console.Write("Wprowadź nazwę produktu: ");
                            string nazwap = Console.ReadLine();

bool znaleziono = false;

                            foreach (Produkt elementy in list)
                            {
                                if (elementy.nazwa.Equals(nazwap))
                                {

                                    elementy.Wyswietl();
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
                            break;
                        }
                    case 4: // zmiana ilosci produktu
                        {
                            Console.Write("Wprowadź nazwę produktu: ");
                            string nazwap = Console.ReadLine();

bool znaleziono = false;

                            foreach (Produkt elementy in list)
                            {
                                if (elementy.nazwa.Equals(nazwap))
                                {
                                    Console.WriteLine("\nIlość zapamiętana: {0,13}\n", elementy.ilosc);
                                    Console.Write("Wprowadź obecny stan ilościowy: ");
                                    string nil = Console.ReadLine();
elementy.Set_ilosc(nil);

                                    Console.WriteLine("\nZmieniono ilość!\n");
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

                            break;
                        }

                    case 0: // Koniec programu
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("\nNie ma takiej opcji.\n");
                            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                }
            }
            Console.ReadKey();
            Console.ReadKey();
            */
    }
}

