using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AOC22
{
    class Day4
    {



        public void Day4Calc()
        {
            int shareCountA = 0;
            int shareCountB = 0;
            char[] separators = { ',', '-' };

            InputReader inputReader = new InputReader();

            string actualPath = inputReader.GetActualPath("Input4.txt");
            foreach (string line in File.ReadLines(actualPath))
            {
                string[] str = line.Split(separators);
                int[] pos = Array.ConvertAll(str, s => int.Parse(s));

                // 3A 
                if ((pos[0] <= pos[2] && pos[1] >= pos[3]) || (pos[0] >= pos[2] && pos[1] <= pos[3]))
                {
                    shareCountA++;
                }
                shareCountB += FindOverlap(pos[0], pos[1], pos[2], pos[3]);
            }
            Console.WriteLine("\nDay 4A Calc: " + shareCountA);
            Console.WriteLine("Day 4B Calc: " + shareCountB);
        }
        public int FindOverlap(int start1, int end1, int start2, int end2)
        {
            var find = Math.Max(0, Math.Min(end1, end2) - Math.Max(start1, start2) + 1);

            if (find == 0) return 0;
            else return 1;
        }
    }
}
