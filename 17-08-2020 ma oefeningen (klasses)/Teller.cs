using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public class Teller
    {
        private int MijnTeller = 0;

        public Teller()
        {
        }

        public void Bekijken()
        {
            MessageBox.Show(MijnTeller.ToString());
        }

        public void Reset()
        {
            MijnTeller = 0;
        }

        public void Verhogen()
        {
            MijnTeller++;
        }

        public void Verlagen()
        {
            MijnTeller--;
        }
    }
}
