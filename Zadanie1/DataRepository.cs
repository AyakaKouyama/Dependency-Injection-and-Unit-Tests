using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections.ObjectModel;
using Zadanie1;

namespace Zadanie1
{
    public class DataRepository
    {
        private IWypelnianie filler;
        private DataContext _data;

        public DataRepository(IWypelnianie filler)
        {
            if(filler == null)
            {
                throw new ArgumentNullException(nameof(filler));
            }
            this._data = new DataContext();
            this.filler = filler;
            filler.Fill(this);
        }

        public void CreateKsiazka(Ksiazka ksiazka)
        {
            _data.ksiazki.Add(ksiazka.Id, ksiazka);
        }
        public void CreateWypozyczenie(Wypozyczenie wypozyczenie)
        {
            _data.wypozyczenia.Add(wypozyczenie);
        }
        public void CreateCzytelnik(Czytelnik czytelnik)
        {
            _data.czytelnicy.Add(czytelnik);
        }
        public void CreateOpisStanu(OpisStanu opis)
        {
            _data.stan.Add(opis);
        }


        public Ksiazka GetKsiazka(int id)
        {
            return _data.ksiazki[id];
        }
        public Wypozyczenie GetWypozyczenie(int id)
        {
            return _data.wypozyczenia[id];
        }
        public Czytelnik GetCzytelnik(int id)
        {
            return _data.czytelnicy[id];
        }
        public OpisStanu GetOpisStanu(int id)
        {
            return _data.stan[id];
        }


        public Dictionary<int, Ksiazka> GetAllKsiazka()
        {
            return _data.ksiazki;
        }
        public ObservableCollection<Wypozyczenie> GetAllWypozyczenie()
        {
            return _data.wypozyczenia;
        }
        public List<Czytelnik> GetAllCzytelnicy()
        {
            return _data.czytelnicy;
        }
        public List<OpisStanu> GetAllOpisStanu()
        {
            return _data.stan;
        }


        public void DeleteKsiazka(Ksiazka element)
        {
            _data.ksiazki.Remove(element.Id);
        }
        public void DeleteWypozyczenie(Wypozyczenie element)
        {
            _data.wypozyczenia.Remove(element);
        }
        public void DeleteCzytelnik(Czytelnik element)
        {
            _data.czytelnicy.Remove(element);
        }
        public void DeleteOpisStanu(OpisStanu element)
        {
            _data.stan.Remove(element);
        }


        public void UpdateKsiazka(int id, Ksiazka element)
        {
            _data.ksiazki[id] = element;
        }
        public void UpdateWypozyczenie(int id, Wypozyczenie element)
        {
            _data.wypozyczenia[id] = element;
        }
        public void UpdateCzytelnik(int id, Czytelnik element)
        {
            _data.czytelnicy[id] = element;
        }
        public void UpdateOpisStanu(int id, OpisStanu element)
        {
            _data.stan[id] = element;
        }

    }
}


