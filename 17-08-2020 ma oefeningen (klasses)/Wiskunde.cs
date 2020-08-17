using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public class Wiskunde
    {
        public int Punten { get; set; }

        public Wiskunde(int punten)
        {
            Punten = punten;
        }
        public override string ToString()
        {
            return Convert.ToString(Punten);
        }
    }
}
