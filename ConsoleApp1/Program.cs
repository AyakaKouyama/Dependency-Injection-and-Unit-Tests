using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService service = new DataService(new DataRepository(new WypelnianieStalymi()));
            service.WyswietlaniePowiazanychDanych();

            Console.Read();
        }
    }
}
