using System;
using System.Collections.Generic;
using System.Text;

namespace bridge
{
   public class SpecialRemote : RemoteControl
    {
        public SpecialRemote(TVFactory tvFactory) : base(tvFactory)
        {
           
        }
        public void up()
        {
            int channel = this.getChannel();
           setChannel(channel + 1);
        }
        public void down()
        {
            int channel = this.getChannel();
            setChannel(channel - 1);
        }
    }
}
