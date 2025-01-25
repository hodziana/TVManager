using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVManager
{
    public class Film
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; } // U minutama
        public TimeSpan VrijemePocetka { get; set; } // HH:mm:ss
        public string DanPrikazivanja { get; set; } // Npr. Ponedjeljak
        public int Prioritet { get; set; } // 0, 1, 2
        public bool Rezervan { get; set; } // True/False
    }
}
