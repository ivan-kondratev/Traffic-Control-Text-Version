using System;
using System.Collections.Generic;
using System.Text;

namespace Traffic_Control_Text_Version
{
    class Speeding
    {
        public int Value { get; private set; }

        public Speeding()
        {
            Random random = new Random();
            Array speedingArray = Enum.GetValues(typeof(SpeedingEnum));
            Value = (int)speedingArray.GetValue(random.Next(speedingArray.Length));
        }
    }
}
