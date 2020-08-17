using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public class Frans
    {
        public int Punten { get; set; }

        public Frans(int punten)
        {
            Punten = punten;
        }
        public override string ToString()
        {
            return Convert.ToString(Punten);
        }
    }
}
