using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    public class OpisStanu
    {
        private Ksiazka _ksiazka;
        private bool _czyWypozyczona;
        private int _warotsc;
        public int Wartosc { get => _warotsc; set => _warotsc = value; }
        public bool CzyWypozyczona { get => _czyWypozyczona; set => _czyWypozyczona = value; }
        public Ksiazka Ksiazka { get => _ksiazka; set => _ksiazka = value; }

        public OpisStanu(Ksiazka ksiazka, bool czyWypozyczona, int wartosc)
        {
            this._ksiazka = ksiazka;
            this._czyWypozyczona = czyWypozyczona;
            this._warotsc = wartosc;
        }


    }
}
