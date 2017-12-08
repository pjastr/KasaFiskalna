using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Aplikacja
    {
        public char klawisz;

        public void WczytajKlawisz()
        {
            Console.WriteLine("Legenda:");
            Console.WriteLine("P-dodaj produkt");
            Console.WriteLine("K-kasuj produkt");
            Console.WriteLine("Z-zawartosc");
            Console.WriteLine("S-suma do zaplaty");
            Console.WriteLine("X-skasuj produkt z listy");
            Console.WriteLine("W-paragon");
            Console.WriteLine("N-nowy koszyk");
            Console.WriteLine("E-koniec programu");
            Console.WriteLine("");
            klawisz = Console.ReadKey().KeyChar;
            Console.WriteLine("");
        }
        public void WykonajDzialanie()
        {
            Koszyk kosz1= new Koszyk();
            if (klawisz == 'P' || klawisz =='p') 
            {

                kosz1.DodajP();

            }

            else if  (klawisz == 'K' || klawisz == 'k')
            {

            }

            else if  (klawisz == 'Z' || klawisz == 'z')
            {
                //int liczba = zakupy.Count; nie ma dostępu do tego pola
                //for (int i = 0; i < liczba; ++i)
                //{

                //}
            }

            else if(klawisz == 'S' || klawisz == 's')
            {

            }

            else if(klawisz == 'X' || klawisz == 'x')
            {

            }

            else if(klawisz == 'W' || klawisz == 'w')
            {

            }

            else if(klawisz == 'N' || klawisz == 'n')
            {

            }

            else if(klawisz == 'E' || klawisz == 'e')
            {
                Console.WriteLine("Koniec programu");
            }

            else Console.WriteLine("Zly klawisz");
        }

        public Aplikacja() { }
    }
}
