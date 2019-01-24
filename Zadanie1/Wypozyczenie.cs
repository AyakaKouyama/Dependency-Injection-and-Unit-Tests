using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    public class Wypozyczenie
    {
        private Czytelnik _czytelnik;
        private OpisStanu _stan;

        public Czytelnik Czytelnik  { get => _czytelnik; set => _czytelnik = value; } 
        public OpisStanu Stan { get => _stan; set => _stan = value; }

        public Wypozyczenie(Czytelnik czytelnik, OpisStanu stan)
        {
            this._czytelnik = czytelnik;
            this._stan = stan;
        }

    }
}


    

