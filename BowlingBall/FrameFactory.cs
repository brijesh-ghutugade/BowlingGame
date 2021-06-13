using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class FrameFactory
    {
        public Frame CreateFrame(int firstRoll, int secondRoll)
        {
            if (firstRoll == 10)
                return new StrikeFrame(firstRoll, 0);

            if ((firstRoll + secondRoll) == 10)
                return new SpareFrame(firstRoll, secondRoll);

            return new OpenFrame(firstRoll, secondRoll);
        }

        public Frame CreateFrame(int firstRoll, int secondRoll, int thirdRoll)
        {
            return new LastFrame(firstRoll, secondRoll, thirdRoll);
        }
    }
}
