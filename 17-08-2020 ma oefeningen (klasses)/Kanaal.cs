using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public class Kanaal
    {
        public int Channel { get; set; }
        public string Channelname { get; set; }

        public Kanaal(int channel, string channelname)
        {
            Channel = channel;
            Channelname = channelname;
        }
       
    }
}
