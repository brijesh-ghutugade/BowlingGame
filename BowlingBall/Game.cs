using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game
    {

        private FrameFactory _frameFactory = new FrameFactory();

        private readonly List<Frame> _frames = new List<Frame>();

        public void Roll(int firstRoll, int secondRoll)
        {

            if (_frames.Count == 10)
            {
                throw new InvalidOperationException("Game Finish!");
            }

            var frame = _frameFactory.CreateFrame(firstRoll, secondRoll);
            _frames.Add(frame);
        }

        public void RollLastFrame(int firstRoll, int secondRoll, int thirdRoll)
        {

            var frame = _frameFactory.CreateFrame(firstRoll, secondRoll, thirdRoll);
            _frames.Add(frame);
        }

        public int CalculateScore()
        {

            // Calculate Bonuses for each Frame
            for (int i = 0; i < 8; i++)
            {
                _frames[i].CalculateBonus(_frames[i + 1], _frames[i + 2]);
            }

            // Second last and last frames
            _frames[8].CalculateBonus(_frames[9], null);
            _frames[9].CalculateBonus(null, null);

            // Add all scores
            int finalScore = 0;

            foreach (var frame in _frames)
            {
                finalScore += frame.GetScrore();
            }

            return finalScore;
        }
    }
}
