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
            crates = new char[200];
            this.rowID = rowID;
        }

        public void SetupCrate(int height, char crate)
        {
            crates[height] = crate;
            if (crate != ' ') { totalCrates++; }
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

        public void RemoveCrate()
        {
            crates[currentHeight] = ' ';
            currentHeight--;
        }

        public char IDTopCrate(bool report)
        {
            //      
            if (report) { Console.WriteLine("Top crate on stack {1} -> {0}", crates[currentHeight], rowID); }
            return crates[currentHeight];
        }
    }

    class Day5
    {
        public void Instruction(int quant, int start, int end, Stack[] stacks)
        {
            for (int i = 0; i < quant; i++)
            {
                char pickup = stacks[start - 1].IDTopCrate(false);
                stacks[start - 1].RemoveCrate();
                stacks[end - 1].AddCrate(pickup);
           //     Console.WriteLine("Moving for the {0}th time - crate {1} from Stack {2} to Stack {3}", quant, pickup, start, end);
            }
        }

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
                stacks[i].IDTopCrate(false);

            }

            for (int i = 0; i < stacks.Length; i++)
            {
                stacks[i].IDTopCrate(false);
            }

            // I NEED TO READ THROUGH AND EXECUTE ALL INSTRUCTIONS HERE
            lineCount = 0;
            foreach (string line in File.ReadLines(actualPath))
            {
                if (lineCount > 9)
                {
                    string[] inst = line.Split(' ');

                    for (int i = 0; i < inst.Length; i++)
                    {
                        //      Console.WriteLine(inst[i]);
                    }
                    Console.WriteLine(inst[1]);
                    Console.WriteLine(inst[3]);
                    Console.WriteLine(inst[5]);

                    Instruction(Int32.Parse(inst[1]), Int32.Parse(inst[3]), Int32.Parse(inst[5]), stacks);
                }
                lineCount++;
            }

            for (int i = 0; i < stacks.Length; i++)
            {
                stacks[i].IDTopCrate(true);
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
