using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVManager
{
    public class Emisija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; } // U minutama
        public TimeSpan VrijemePocetka { get; set; } // HH:mm:ss
        public List<string> DaniPrikazivanja { get; set; } // Ponedjeljak, Utorak...
        public int Prioritet { get; set; } // 0, 1, 2, 3
        public bool Rezervna { get; set; } // True/False
    }
}
