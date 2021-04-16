using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Baza
{
    class Samohut
    {
        public int ID { set; get; }
        public string Marka { set; get; }
        public string Model { set; get; }
        public int kuce { set; get; }
    }
    class garage : DbContext
    {
        public virtual DbSet<Samohut> furki { set; get; }
    }
}
