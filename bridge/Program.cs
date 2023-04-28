using System;

namespace bridge
{
    public class Program
    {
        static void Main(string[] args)
        {
            TVFactory tvFactory = new TVFactory();
            SpecialRemote remoteSony = new SpecialRemote(tvFactory);
            Console.WriteLine("Connect your remote to the TV");
            remoteSony.setTV("Sony");
            remoteSony.on();
            remoteSony.up();
            remoteSony.down();
            remoteSony.off();

            GenericRemote remoteLG = new GenericRemote(tvFactory);
            Console.WriteLine("Connect your remote to the TV");
            remoteLG.setTV("Sony");
            remoteLG.on();
            remoteLG.nextChannel();
            remoteLG.prevChannel();
            remoteLG.off();
        }
    }
}
