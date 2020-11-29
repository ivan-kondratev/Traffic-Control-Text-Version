using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class SpeedLimit
    {
        public int Value { get; private set; }

        public SpeedLimit()
        {
            Array speedLimitArray = Enum.GetValues(typeof(SpeedLimitEnum));
            Random random = new Random();
            Value = (int)speedLimitArray.GetValue(random.Next(speedLimitArray.Length));
        }
    }
}
