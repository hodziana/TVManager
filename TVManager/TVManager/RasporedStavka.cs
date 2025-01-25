using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVManager
{
    internal class RasporedStavka
    {
        public string Naziv { get; set; }
        public string Tip { get; set; } // Emisija, Film, Reklama
        public TimeSpan VrijemePocetka { get; set; }
        public int Trajanje { get; set; } // u minutama
        public int Prioritet { get; set; } // -1 za reklame

        public RasporedStavka(string naziv, string tip, TimeSpan vrijemePocetka, int trajanje, int prioritet)
        {
            Naziv = naziv;
            Tip = tip;
            VrijemePocetka = vrijemePocetka;
            Trajanje = trajanje;
            Prioritet = prioritet;
        }
    }
}
