using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int liczba = 0;

        //    Func<string, string, int> suma = (tekst1, tekst2) => tekst1.Length + tekst2.Length;
        //    string pierwszy = "porsze";
        //    string drugi = "lambordżini";
        //    liczba = suma(pierwszy, drugi);

        //    Console.WriteLine(liczba);

        //    Console.ReadLine();
        //}
        static void Main(string[] args)
        {
            string[] imiona = { "Ola", "Agata", "Wincent", "Jacek" };

            var wynik = imiona.Select(n => n.ToUpper()).Where(a => a.Contains("C")).OrderBy(b => b.Length);
            
            foreach(var l in wynik)
            {
                Console.WriteLine(l);
            }

            Console.ReadLine();
        }
    }
}
