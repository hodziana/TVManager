using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVManager
{
    public class RasporedBlok
    {
        public TimeSpan VrijemePocetka { get; set; }
        public TimeSpan VrijemeZavrsetka { get; set; }
        public string Tip { get; set; } // "Film", "Emisija", "Reklame", "Rezervni program"
        public string Naziv { get; set; }
    }
}
