using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_08_2020_ma_oefeningen__klasses_
{
    public class Televisie
    {
        public List<Kanaal> MijnKanaal { get; set; }
        public int Volume { get; set; }

        public Televisie(int volume)
        {
            MijnKanaal = new List<Kanaal>();
            Volume = volume;
        }

        public void VolumeUp()
        {
            Volume++;
        }
        public void VolumeDown()
        {
            Volume--;
        }

        public string CurrentChannel(int currentChannel)
        {
            foreach (var channel in MijnKanaal)
            {
                if (channel.Channel == currentChannel)
                {
                    return $"Kanaal: {channel.Channelname}";
                }
            }
            return $"Kanaal: Static";
        }

    }
}
