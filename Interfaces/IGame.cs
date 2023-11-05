using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingCalculator.Interfaces
{
    public interface IGame
    {
        int RecordScore(List<int> frame);
        int PlayGame();
        int GetScore();
        void ResetGame();
    }
}
