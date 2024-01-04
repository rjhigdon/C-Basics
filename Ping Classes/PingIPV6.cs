using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class PingIPV6 : BasePing
    {
        //Differnt Implementation starting here
        public override bool Init()
        {
            return false;
        }
        public bool SendPing()
        {
            return true;
        }
    }
}
