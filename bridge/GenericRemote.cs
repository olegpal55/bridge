using System;
using System.Collections.Generic;
using System.Text;

namespace bridge
{
    public class GenericRemote : RemoteControl
    {
        public GenericRemote(TVFactory tvFactory) : base(tvFactory)
        {
        }

        public void nextChannel ()
        {
            int channel = this.getChannel();
            setChannel(channel + 1);
        }
        public void prevChannel()
        {
            int channel = this.getChannel();
            setChannel(channel - 1);
        }
    }
}