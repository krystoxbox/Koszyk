using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koszyk
{
    public class Przedmiot
    {
        public string nazwa;
        public int cena;
        public int ilosc;

        public Przedmiot(string nazwa, int cena, int ilosc)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.ilosc = ilosc;
        }
    }
}
