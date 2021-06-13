using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class SpareFrame: Frame
    {
        public SpareFrame(int firstRoll, int secondRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
        }

        public override void CalculateBonus(Frame nextFrame, Frame nextToNextFrame)
        {
            _bonus += nextFrame.FirstRoll;
        }
    }
}
