using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaFiskalna
{
    class Produkt
    {
        public string nazwa;
        public double cenaJednostkowa;
        public int ilosc;



        public Produkt(string nazwa, double cenaJednostkowa, int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }
    }
}
