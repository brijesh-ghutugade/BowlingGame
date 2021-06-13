using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class LastFrame : Frame
    {
        public LastFrame(int firstRoll, int secondRoll, int thirdRoll)
        {
            _firstRoll = firstRoll;
            _secondRoll = secondRoll;
            _thirdRoll = thirdRoll;
        }

        protected int _thirdRoll;

        public override void CalculateBonus(Frame nextFrame, Frame nextToNextFrame)
        {
            _bonus += _thirdRoll;
        }
    }
}
