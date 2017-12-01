using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Program
    {
        static void Main(string[] args)
        {
            Aplikacja sklep = new Aplikacja();
            while(sklep.klawisz != 'E' && sklep.klawisz != 'e')
            {
                sklep.WczytajKlawisz();
                sklep.WykonajDzialanie();
            }




            Console.ReadKey();
        }
    }
}
