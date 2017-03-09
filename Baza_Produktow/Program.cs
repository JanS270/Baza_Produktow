using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_Produktow
{
    class Produkt
    {
        int ilosc = 0;
        float cena = 0;
        string nazwa = "Brak";
        Produkt(string nz, string cn, string il)
        {
            nazwa = nz;
            cena = float.Parse(cn);
            ilosc = Int32.Parse(il);
        }

        void Set_Cena(string cn)
        {
            cena = float.Parse(cn);
        }
        void Set_ilosc(string il)
        {
            ilosc = Int32.Parse(il);
        }

        void Wyswietl()
        {
            Console.Write("\nProdukt:{0,30}\n", nazwa);
            Console.Write("Cena:{0,33}\n", cena);
            Console.Write("Ilość:{0,32}\n\n", ilosc);
        }


        /*////////////// MAIN ////////////*/

        static void Main(string[] args)
        {
            int wybor;
            string str_wybor;

            List<Produkt> list = new List<Produkt>(); //Tworzy liste produktow

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("****\tZARZĄDZANIE MAGAZYNEM\t****");
                Console.WriteLine(" 1. Dodaj Produkt");
                Console.WriteLine(" 2. Sprawdź Stan");
                Console.WriteLine(" 3. Znajdź Produkt");
                Console.WriteLine(" 4. Zmień ilość produktu");
                Console.WriteLine(" 0. Koniec Progamu");
                Console.Write(" Wybór: ");
                str_wybor = Console.ReadLine();
                wybor = Int32.Parse(str_wybor);
                // kOMENT
                switch (wybor)
                {
                    case 1:  // Dodawanie produktu
                        {
                            Console.Write("\nPodaj nazwę produktu: ");
                            string naz = Console.ReadLine();
                            Console.Write("Podaj cenę produktu: ");
                            string cen = Console.ReadLine();
                            Console.Write("Podaj ilość produktu: ");
                            string ilo = Console.ReadLine();
                            list.Add(new Produkt(naz, cen, ilo)); // Dodaje element do listy produktow
                            Console.WriteLine("\nZapisano Produkt!\n");
                            Console.WriteLine("Naciśnij enter aby kontynuować...\n");
                            Console.ReadLine();
                            Console.Clear();
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

        }
    }
}
