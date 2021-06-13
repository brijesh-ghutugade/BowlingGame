using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public abstract class Frame
    {
        protected int _firstRoll;

        public int FirstRoll
        {
            get { return _firstRoll; }
        }

        
        protected int _secondRoll;

        public int SecondRoll
        {
            get { return _secondRoll; }
        }

        protected int _bonus;

        public int GetScrore() {
            return _firstRoll + _secondRoll + _bonus;
        }

        public abstract void CalculateBonus(Frame nextFrame, Frame nextToNextFrame);

    }
}
