using System;

namespace Zadanie1
{
    public class Czytelnik
    {
        private string _imie;
        private string _nazwisko;
        private string _pesel;

        public string Imie { get => _imie; set => _imie = value; }
        public string Nazwisko { get => _nazwisko; set => _nazwisko = value; }
        public string Pesel { get => _pesel; set => _pesel = value; }

        public Czytelnik(string _imie, string _nazwisko, string _pesel)
        {
            this._imie = _imie;
            this._nazwisko = _nazwisko;
            this._pesel = _pesel;
        }
    }
}
