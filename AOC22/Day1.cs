using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AOC22
{
     class Day1
    {
        private List<int> calorieList;
        private InputReader inputReader;



        public void Day1Calc()
        {
            Console.WriteLine("\n \n Starting Day 1 Calc: \n \n");

            int highestCount = CollectPuzzleData().Max();
            Console.WriteLine("Day 1 Solution - Highest Elf Calorie Count: " + highestCount);
        }


        public List<int> CollectPuzzleData()
        {
            inputReader = new InputReader();
            string inputPath = StartAOC.InputBin.ToString() + "Input1.txt";

            calorieList = inputReader.ReadInputGroups(inputPath);

            Console.WriteLine(calorieList.ElementAt(0));

            return calorieList;
        }
    }
}