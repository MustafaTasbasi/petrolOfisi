using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petrolOfisi.Model
{
    internal class Pompa
    {
        public Pompa(int id, string isim)
        {
            this.id = id;
            this.isim = isim;
        }

        public Pompa() { }

        public int id { get; set; }
        public string isim { get; set; }
    }
}
