using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BowlingCalculator.Interfaces;

namespace BowlingCalculator
{
    public sealed class BowlingGame : IGame
    {
        private readonly IFrame _frame;        
        private readonly Dictionary<int, int> _frameScore;

        /// <summary>
        /// Constructor for Bowling game
        /// </summary>
        /// <param name="frame"></param>
        public BowlingGame(IFrame frame)
        {
            _frame = frame;           
            _frameScore = new Dictionary<int, int>();
        }

        /// <summary>
        /// Returns the score of the frame passed in
        /// </summary>
        /// <param name="roll">List<int> (Frame object)</param>
        /// <returns>total of the passed frame score</returns>
        internal int GetFrameScore(List<int> roll)
        {
            return _frame.CalculateFrame(roll);
        }

        /// <summary>
        /// Removes a roll from storage
        /// </summary>
        /// <param name="frameId">int (The id from the frame)</param>
        internal void RemoveRoll(int id)
        {
            _frameScore.Remove(id);
        }
        /// <summary>
        /// Get the Game History
        /// </summary>
        public Dictionary<int, int> GetGameStats { get { return _frameScore; } } 

        /// <summary>
        /// Reset the game
        /// </summary>
        public void ResetGame()
        {
            _frameScore.Clear();            
        }

        /// <summary>
        /// Records a frame scores one frame at a time
        /// </summary>
        /// <param name="roll">the frame score</param>
        /// <returns>int (the frame id)</returns>
        public int RecordScore(List<int> roll)
        {
            int frameId = _frameScore.Count;
            int score = -1;
            if (frameId < 10)
            {
                //_rolls.Add(rollId, roll);
                score = GetFrameScore(roll);
                _frameScore.Add(frameId, score);
            }
            return frameId;
        }


        /// <summary>
        /// Total all the frames up to the current frame
        /// </summary>
        /// <returns>int (the score of all entered frames)</returns>
        public int GetScore()
        {
            int total = 0;
            foreach (var roll in _frameScore.Values)
            {
                total += roll;
            }
            return total;
        }


        /// <summary>
        /// Play the game aginst all entered frames
        /// </summary>
        /// <returns>int (the score of all entered frames)</returns>
        public int PlayGame()
        {
            // 0 = open or gutterball
            return GetScore();
        }
    }

}
