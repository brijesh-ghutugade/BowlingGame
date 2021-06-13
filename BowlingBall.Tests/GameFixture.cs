using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        //[TestMethod]
        //public void Gutter_game_score_should_be_zero_test()
        //{
        //    var _game = new Game();
        //    Roll(_game, 0, 20);
        //    Assert.AreEqual(0, _game.GetScore());
        //}

        //private void Roll(Game _game, int pins, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        _game.Roll(pins);
        //    }
        //}

        // Tests written as per new design 

        private Game _game;

        [TestInitialize]
        public void Prepare()
        {
            _game = new Game();
        }



        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {

            for (int i = 1; i <= 10; i++)
            {
                _game.Roll(0, 0);
            }

            Assert.AreEqual(0, _game.CalculateScore());

        }


        [TestMethod]
        public void Game_score_should_be_80_with_all_fours_test()
        {

            for (int i = 1; i <= 10; i++)
            {
                _game.Roll(4, 4);
            }

            Assert.AreEqual(80, _game.CalculateScore());

        }


        [TestMethod]
        public void Game_score_should_be_86_with_all_fours_and_firstSpare_test()
        {

            // First Spare and later all 4s
            _game.Roll(5, 5);

            for (int i = 1; i <= 9; i++)
            {
                _game.Roll(4, 4);
            }

            Assert.AreEqual(86, _game.CalculateScore());

        }


        [TestMethod]
        public void Game_score_should_be_90_with_all_fours_and_firstStrike_test()
        {
            

            // First Strike and later all 4s
            _game.Roll(10, 0);

            for (int i = 1; i <= 9; i++)
            {
                _game.Roll(4, 4);
            }

            Assert.AreEqual(90, _game.CalculateScore());

        }

        [TestMethod]
        public void Game_score_should_be_106_with_all_fours_and_firstTwoStrikes_test()
        {
            

            // First two Strikes and later all 4s
            _game.Roll(10, 0);
            _game.Roll(10, 0);

            for (int i = 1; i <= 8; i++)
            {
                _game.Roll(4, 4);
            }

            Assert.AreEqual(106, _game.CalculateScore());

        }


        [TestMethod]
        public void Game_score_should_be_300_with_all_strikeFrames_test()
        {
                        

            for (int i = 1; i <= 9; i++)
            {
                _game.Roll(10, 0);
            }

            _game.RollLastFrame(10, 10, 10);

            Assert.AreEqual(300, _game.CalculateScore());

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Game_should_throw_exception()
        {            
            for (int i = 0; i < 10; i++) { _game.Roll(0, 0); }
            _game.Roll(0, 0);
        }

    }
}
