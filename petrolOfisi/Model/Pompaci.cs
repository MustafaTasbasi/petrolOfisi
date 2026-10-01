using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petrolOfisi.Model
{
    internal class Pompaci
    {
        public Pompaci(int id, string ad, string soyad, string telefon)
        {
            this.id = id;
            this.ad = ad;
            this.soyad = soyad;
            this.telefon = telefon;
        }

        public Pompaci() { }

        public int id {  get; set; }
        public string ad {  get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public string Ad { get; internal set; }
        public string Soyad { get; internal set; }
    }
}
