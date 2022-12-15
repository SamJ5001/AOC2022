using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AOC22
{
    class Day4
    {
        public void Day4Calc()
        {
            int shareCount = 0;
            char[] separators = { ',', '-' };

            InputReader inputReader = new InputReader();

            string actualPath = inputReader.GetActualPath("Input4.txt");
            foreach (string line in File.ReadLines(actualPath))
            {
                string[] str = line.Split(separators);
                int[] pos = Array.ConvertAll(str, s => int.Parse(s));

                if ((pos[0] <= pos[2] && pos[1] >= pos[3]) || (pos[0] >= pos[2] && pos[1] <= pos[3]))
                {
                    shareCount++;
              //      Console.WriteLine("{0}-{1} or {2}-{3} contain one another. Share count is now {4}", pos[0], pos[1], pos[2], pos[3], shareCount);
                }
            }

            Console.WriteLine("\nDay 4A Calc: " + shareCount);
        }
    }
}
