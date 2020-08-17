using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassesExtended
{
    public class Persoon
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }

        public Persoon(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }

        public Persoon(string naam)
        {
            Naam = naam;
            Leeftijd = -1;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
