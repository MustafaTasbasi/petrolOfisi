using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petrolOfisi.Model
{
    internal class Arac
    {
        public Arac(int id, string marka, string model, string plaka, int yakit)
        {
            this.id = id;
            this.marka = marka;
            this.model = model;
            this.plaka = plaka;
            this.yakit = yakit;
        }

        public Arac() { }

        public int id { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public string plaka { get; set;}
        public int yakit { get; set; }
    }
}
