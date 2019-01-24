using System;
using System.Collections.Generic;
using System.Text;
using Zadanie1;

namespace ConsoleApp1
{
    public class WypelnianieStalymi : IWypelnianie
    {
        public void Fill(DataRepository repository)
        {
            repository.CreateCzytelnik(new Czytelnik("Jan", "Kowalski", "123456789"));
            repository.CreateCzytelnik(new Czytelnik("Krystian", "Nowak", "12345219"));
            repository.CreateCzytelnik(new Czytelnik("Sebastian", "Dzik", "11522789"));
            repository.CreateCzytelnik(new Czytelnik("Łukasz", "Mazurek", "1235456789"));
            repository.CreateCzytelnik(new Czytelnik("Eliasz", "Masłowski", "123451259"));
            repository.CreateCzytelnik(new Czytelnik("Krzysztof", "Lubomierski", "1155456789"));
            repository.CreateCzytelnik(new Czytelnik("Stefan", "Nowak", "1234561249"));
            repository.CreateCzytelnik(new Czytelnik("Artur", "Nirzejewski", "12341249"));
            repository.CreateCzytelnik(new Czytelnik("Jan", "Pomorski", "123454119"));
            repository.CreateCzytelnik(new Czytelnik("Anna", "Kujawa", "123455589"));

            repository.CreateKsiazka(new Ksiazka(1, "Lalka", "Bolesław Prus"));
            repository.CreateKsiazka(new Ksiazka(2, "Krzyzacy", "Henryk Sienkiewicz"));
            repository.CreateKsiazka(new Ksiazka(3, "Opium w Rosole", "Małgorzata Musierowicz"));
            repository.CreateKsiazka(new Ksiazka(4, "Dżuma", "Albert Camus"));
            repository.CreateKsiazka(new Ksiazka(5, "Chłopi", "Władysław Raymont"));
            repository.CreateKsiazka(new Ksiazka(6, "Ogniem i mieczem", "Henryk Sienkiewicz"));

            for (int i = 1; i < 7; i++)
            {
                repository.CreateOpisStanu(new OpisStanu(repository.GetKsiazka(i), false, i * 10));
            }

            for (int i = 0; i < 5; i++)
            {
                repository.CreateWypozyczenie(new Wypozyczenie(repository.GetCzytelnik(i), repository.GetOpisStanu(i)));
                repository.GetOpisStanu(i).CzyWypozyczona = true;
            }

        }
    }
}
