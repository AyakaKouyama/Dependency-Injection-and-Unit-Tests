using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Zadanie1
{
    public class DataContext
    {
        public List<Czytelnik> czytelnicy;
        public Dictionary<int, Ksiazka> ksiazki;
        public ObservableCollection<Wypozyczenie> wypozyczenia;
        public List<OpisStanu> stan;

        public DataContext()
        {
            czytelnicy = new List<Czytelnik>();
            ksiazki = new Dictionary<int, Ksiazka>();
            wypozyczenia = new ObservableCollection<Wypozyczenie>();
            stan = new List<OpisStanu>();
        }

       
    }
}
