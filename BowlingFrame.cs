using BowlingCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BowlingCalculator
{
    public class BowlingFrame : IFrame
    {
        
        public int CalculateFrame(IList<int> rolls)
        {
            int total = 0;
            for (int i = 0; i + 1 < rolls.Count; i += 2)
            {
                //Open Frame
                if (rolls[i] + rolls[i + 1] < 10)
                {
                    total = rolls[i] + rolls[i + 1];
                    break;
                }

                //Spare and Strike require 3 rolls
                if (i + 2 >= rolls.Count)
                {
                    break;
                }

                //sum the spare or strike
                total = rolls[i] + rolls[i + 1] + rolls[i + 2];
            }
            return total;
        }

    }
}
