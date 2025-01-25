using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVManager
{
    internal class BlokReklama
    {
        public int Id { get; set; }
        public List<int> ReklameIds { get; set; } // ID-evi reklama u ovom bloku
        public string Termin { get; set; } // "prije" ili "tijekom"

        // Konstruktor
        public BlokReklama()
        {
            ReklameIds = new List<int>();
        }
    }
}
