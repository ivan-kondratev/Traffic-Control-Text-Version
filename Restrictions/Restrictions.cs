using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class Restrictions
    {
        public SpeedLimit speedLimit;
        public Speeding speeding;

        public Restrictions()
        {
            speedLimit = new SpeedLimit();
            speeding = new Speeding();
        }

    }
}
