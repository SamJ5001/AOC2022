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
           
            d1.Day1Calc();
            d2.Day2Calc();
        }
    }
}
