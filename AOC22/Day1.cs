using System;
using System.Collections;
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
        private List<int> sortedList;
        private InputReader inputReader;

        public void Day1Calc()
        {
            Console.WriteLine("\n \n Starting Day 1 Calc: \n \n");


            int highestCount = CollectPuzzleData(false).Max();
            Console.WriteLine("Day 1 Solution - Highest Elf Calorie Count: " + highestCount);

            Console.WriteLine("Day 1B Solution - Highest Three Elf Calorie Counts: " + CollectTopElfCount(3));
        }

        public int CollectTopElfCount(int count)
        {
            sortedList = CollectPuzzleData(true);
            var index = sortedList.Count - 1;
            var counter = 0;
            int elfCount = 0;

            while (counter < count)
            {
                elfCount += sortedList[index];
                counter++;
                index--;
            }

            return elfCount;
        }



        public List<int> CollectPuzzleData(bool sort)
        {
            inputReader = new InputReader();
            string inputPath = StartAOC.InputBin.ToString() + "Input1.txt";

            calorieList = inputReader.ReadInputGroups(inputPath);

            if (sort) { calorieList.Sort(); }

            return calorieList;
        }
    }
}