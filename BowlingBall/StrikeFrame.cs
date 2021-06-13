using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class StrikeFrame:Frame
    {
        public StrikeFrame(int firstRoll, int secondRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public override void CalculateBonus(Frame nextFrame, Frame nextToNextFrame)
        {
            if (nextFrame is StrikeFrame)
                _bonus += nextFrame.FirstRoll + nextToNextFrame.FirstRoll;
            else
                _bonus += nextFrame.FirstRoll + nextFrame.SecondRoll;
        }
    }
}
