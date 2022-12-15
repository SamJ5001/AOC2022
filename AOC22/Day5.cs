using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AOC22
{
    public class Stack
    {
        public int rowID;
        public int currentHeight;
        char[] crates;

        private int totalCrates = 0;


        public Stack(int rowID)
        {
            crates = new char[10];
            this.rowID = rowID;
        }

        public void SetupCrate(int height, char crate)
        {
            crates[height] = crate;
            totalCrates++;
            Console.WriteLine("Crate {0} - Height {1} -> {2}", rowID, height, crate);
        }

        public void LockHeightSetup()
        {
            currentHeight = totalCrates;
        }

        public void AddCrate(char crate)
        {
            currentHeight++;
            crates[currentHeight] = crate;
        }
    }

    class Day5
    {
        public void Day5Calc()
        {

            Stack[] stacks = CreateStacks();

            char[] separators = { '[', ']', ' ', };

            List<string> crates = new List<string>();

            InputReader inputReader = new InputReader();
            string actualPath = inputReader.GetActualPath("Input5.txt");

            var lineCount = 0;

            var lineID = 8;
            var stackID = 1;

            CreateStacks();

            foreach (string line in File.ReadLines(actualPath))
            {
                if (lineCount < 8)
                {
                    for (int i = 1; i < line.Length; i += 4)
                    {
                        FillStackSetup(stackID, lineID, line[i], stacks);

                        stackID++;
                        if (lineID < 1) { lineID = 8; break; }
                        if (stackID > 9) { stackID = 1; break; }
                    }
                    lineID--;
                }
                lineCount++;
            }

            for (int i = 0; i < stacks.Length; i++)
            {
                stacks[i].LockHeightSetup();
            }
        }


        public void FillStackSetup(int id, int height, char crate, Stack[] stacks)
        {
            stacks[id - 1].SetupCrate(height, crate);
        }

        public Stack[] CreateStacks()
        {
            Stack stack1 = new Stack(1);
            Stack stack2 = new Stack(2);
            Stack stack3 = new Stack(3);
            Stack stack4 = new Stack(4);
            Stack stack5 = new Stack(5);
            Stack stack6 = new Stack(6);
            Stack stack7 = new Stack(7);
            Stack stack8 = new Stack(8);
            Stack stack9 = new Stack(9);

            return new Stack[] { stack1, stack2, stack3, stack4, stack5, stack6, stack7, stack8, stack9 };

        }
    }
}
