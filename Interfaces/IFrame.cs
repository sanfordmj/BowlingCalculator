using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingCalculator.Interfaces
{
    public interface IFrame
    {
        int CalculateFrame(IList<int> frameRolls);
    }
}
