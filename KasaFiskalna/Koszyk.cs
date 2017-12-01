using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Koszyk
    {
        List<Produkt>zakupy = new List<Produkt>();
    
        public void DodajP()
        {
            string nazwa;
            double cena;
            int ilosc;
            Console.WriteLine("Podaj nazwe");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj cene");
            cena = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj ilosc");
            ilosc = Convert.ToInt32(Console.ReadLine());
            zakupy.Add(new Produkt(nazwa, cena, ilosc));
        }
        public Koszyk() { }
    
    }

}
