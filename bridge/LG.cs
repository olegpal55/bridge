using System;
using System.Collections.Generic;
using System.Text;

namespace bridge
{
   public class LG : TV
    {
        int channel = 1;
        

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
            this.channel = channel;
            Console.WriteLine("Set the LG TV Chanel to " + this.channel);
        }

        public override int getChannel()
        {
            return channel;
        }
    }
}
