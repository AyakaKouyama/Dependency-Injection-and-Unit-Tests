using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1
{
    public class Ksiazka
    {
        private int _id;
        private string _tytul;
        private string _autor;

        public int Id { get => _id; set => _id = value; }
        public string Tytul { get => _tytul; set => _tytul = value; }
        public string Autor { get => _autor; set => _autor = value; }

        public Ksiazka(int _id, string _tytul, string _autor)
        {
            this._id = _id;
            this._tytul = _tytul;
            this._autor = _autor; 
        }
    }
}
