using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petrolOfisi.Model
{
    internal class Satis
    {
        public Satis(int id, int miktar, int arac, int pompa, int pompaci, DateTime tarih)
        {
            this.id = id;
            this.miktar = miktar;
            this.arac = arac;
            this.pompa = pompa;
            this.pompaci = pompaci;
            this.tarih = tarih;
        }

        public Satis() { }

        public int id {  get; set; }
        public int miktar {  get; set; }
        public int arac { get; set; }
        public int pompa { get; set; }
        public int pompaci { get; set; }
        public DateTime tarih { get; set; }
    }
}
