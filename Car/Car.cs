using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class Car
    {
        public int Speed { get; private set; }

        public Car()
        {
            Random random = new Random();
            int from = (int)CarSpeedRangeEnum.from,
                to = (int)CarSpeedRangeEnum.to;
            Speed = random.Next(from, to);
        }
    }

}
