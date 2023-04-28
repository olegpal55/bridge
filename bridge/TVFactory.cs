using System;
using System.Collections.Generic;
using System.Text;

namespace bridge
{
   public class TVFactory
    {
        public TV getTV(String type)
        {
            if (type.Equals("LG"))
            {
                return new LG();
            }
            else if (type.Equals("Sony"))
            {
                return new Sony();
            }
            else
            {
                throw new Exception("Invalid TV Type");
            }
        }
    }
}
