using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC22
{
    internal class StartAOC

    {
        public static string InputBin = @"D:\Repositories\AOC\AOC22\Inputs\";
        static void Main(string[] args)
        {
            Day1 d1 = new Day1();
            Day2 d2 = new Day2();
            Day3 d3 = new Day3();
            Day4 d4 = new Day4();
            Day5 d5 = new Day5();

      //      d1.Day1Calc();
      //      d2.Day2Calc();
      //      d3.Day3Calc();
      //      d4.Day4Calc();
            d5.Day5Calc();
        }
    }
}
