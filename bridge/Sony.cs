using System;
using System.Collections.Generic;
using System.Text;

namespace bridge
{
    class Sony : TV
    {
        int station = 0;


        public override void on()
        {
            Console.WriteLine("Turning on the LG TV");
        }

        public override void off()
        {
            Console.WriteLine("Turning off the LG TV");
        }

        public override void tuneChannel(int channel)
        {
            this.station = channel;
            Console.WriteLine("Set the LG TV Chanel to " + this.station);
        }

        public override int getChannel()
        {
            return station;
        }
    }
}
