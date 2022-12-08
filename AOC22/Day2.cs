using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC22
{
     class Day2
    {
        private InputReader inputReader;

        int totalRounds;
        int totalScore;

        public void Day2Calc()
        {

            inputReader = new InputReader();

            totalScore = 0;

            // So firstly, we're going to load our input data
            // Then we're going to count the number of lines (RPS Rounds)

            totalRounds = inputReader.RPSSetup("input2.txt");
            for (int i = 0; i < totalRounds; i++)
            {
                totalScore += inputReader.RPSScore(i);
            }
            Console.WriteLine("\n \n Day 2 Calc: ");
            Console.Write("Total Score: " + totalScore);
        }
    }
}