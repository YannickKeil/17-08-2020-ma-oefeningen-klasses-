using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public class Rapport
    {
        public List<Wiskunde> WiskundePunten { get; set; }
        public List<Informatica> InformaticaPunten { get; set; }
        public List<Fysica> FysicaPunten { get; set; }
        public List<Nederlands> NederlandsPunten { get; set; }
        public List<Frans> FransPunten { get; set; }

        public Rapport()
        {
            WiskundePunten = new List <Wiskunde>();
            InformaticaPunten = new List<Informatica>();
            FysicaPunten = new List<Fysica>();
            NederlandsPunten = new List<Nederlands>();
            FransPunten = new List<Frans>();
        }
        public int Gemiddelde(string vak)
        {
            int Gemidelde = 0;
            int teller = 0;
            if (vak == "Wiskunde")
            {
                foreach (var item in WiskundePunten)
                {
                    Gemidelde += Convert.ToInt32(item.Punten);
                    teller++;
                }
            }
            else if(vak == "Informatica")
            {
                foreach (var item in InformaticaPunten)
                {
                    Gemidelde += Convert.ToInt32(item.Punten);
                    teller++;
                }
            }
            else if (vak == "Fysica")
            {
                foreach (var item in FysicaPunten)
                {
                    Gemidelde += Convert.ToInt32(item.Punten);
                    teller++;
                }
            }
            else if (vak == "Nederlands")
            {
                foreach (var item in NederlandsPunten)
                {
                    Gemidelde += Convert.ToInt32(item.Punten);
                    teller++;
                }
            }
            else if (vak == "Frans")
            {
                foreach (var item in FransPunten)
                {
                    Gemidelde += Convert.ToInt32(item.Punten);
                    teller++;
                }
            }
            if (teller>0)
            {
                Gemidelde = Gemidelde / teller;
                return Gemidelde;
            }
            return 0;


            
        }
    }
}
