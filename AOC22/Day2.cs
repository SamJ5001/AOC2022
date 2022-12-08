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
        int totalScoreA = 0;
        int totalScoreB = 0;

        public void Day2Calc()
        {

            inputReader = new InputReader();

            totalRounds = inputReader.RPSSetup("input2.txt");
            for (int i = 0; i < totalRounds; i++)
            {
                totalScoreA += inputReader.RPSScore2A(i);
            }
            Console.WriteLine("\n \n Day 2A Calc: ");
            Console.WriteLine("Total Score: " + totalScoreA);

            for (int i = 0; i < totalRounds; i++)
            {
                totalScoreB += inputReader.RPSScore2B(i);
            }
            Console.WriteLine("\n \n Day 2B Calc: ");
            Console.WriteLine("Total Score: " + totalScoreB);

        }
    }
}