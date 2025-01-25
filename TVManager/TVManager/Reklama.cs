using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVManager
{
    public class Reklama
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Cijena { get; set; } // Cijena reklame
        public string Termin { get; set; } // "prije" ili "tijekom"
        public int Trajanje { get; set; } // U minutama
    }
}
