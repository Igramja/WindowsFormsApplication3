using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class EvidencijaModel
    {
       
        public int id { get; set; }
        public int osoba { get; set; }
        public int vozilo { get; set; }
        public DateTime vrijemeizn { get; set; }
        public DateTime vrijemevr { get; set; }
        public float cijena { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
    }
}
