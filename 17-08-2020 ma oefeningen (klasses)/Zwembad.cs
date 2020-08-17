using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public class Zwembad
    {
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public double Diepte { get; set; }

        public Zwembad(int lengte, int breedte, int diepte)
        {
            Lengte = lengte;
            Breedte = breedte;
            Diepte = diepte;
        }
        public Zwembad()
        {
                
        }
        public double BerekenVolume()
        {
            double Volume = Math.Round(Lengte * Breedte * Diepte * 1000,2);
            return Volume;
        }
    }
}
