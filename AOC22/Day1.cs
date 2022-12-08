using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC22
{
     class Day1
    {
        private List<string> inputText;
        private InputReader inputReader;

        public void CollectPuzzleData()
        {
            inputReader = new InputReader();
            string inputPath = StartAOC.InputBin.ToString() + "Input1.txt";

            inputText = inputReader.ReadInputString(inputPath, true);
            Console.WriteLine(inputText.Count);

        }
    }
}
