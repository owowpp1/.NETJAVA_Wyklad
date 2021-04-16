using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace Baza
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new garage();

            var records = from m in context.furki
                          select m;
            foreach (var record in records)
            {
                context.furki.Remove(record);
            }
            context.SaveChanges();

            Samohut pojast = new Samohut { Marka = "Perzot", Model = "308", kuce = 120 };
            context.furki.Add(pojast);
            pojast = new Samohut { Marka = "Reno", Model = "Megan", kuce = 115 };
            context.furki.Add(pojast);
            pojast = new Samohut { Marka = "Toyote", Model = "Hachiroku", kuce = 120 };
            context.furki.Add(pojast);
            context.SaveChanges();

            var wypisanko = (from v in context.furki select v).ToList<Samohut>();

            foreach (var l in wypisanko)
            {
                Console.Write("ID: {0}    Marka: {1}    Model: {2}    Kuce: {3}\n", l.ID, l.Marka, l.Model, l.kuce );
            }
            Console.Read();
        }
    }
}
