using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petrolOfisi.Model
{
    internal class Yakit
    {
        public Yakit(int id, string tur, decimal fiyat)
        {
            this.id = id;
            this.tur = tur;
            this.fiyat = fiyat;
        }

        public Yakit() { }

        public int id {  get; set; }
        public string tur {  get; set; }
        public decimal fiyat { get; set; }
    }
}
