using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace AOC22
{

    class Day3
    {
        private InputReader inputReader;
        private int totalScoreB = 0;

        int counter = 0;
        int score = 0;
        int groupCounter = 0;
        int groupTicker = 1;

        public void Day3Calc()
        {
            inputReader = new InputReader();

            string[] elfCluster = new string[(inputReader.LineCount("Input3.txt") / 3) + 1];

            string actualPath = inputReader.GetActualPath("Input3.txt");
            foreach (string line in File.ReadLines(actualPath))
            {
                int count = line.Length;

                int[] BagA = new int[count / 2];
                int[] BagB = new int[count / 2];

                char[] chars = line.ToCharArray();
                int[] nums = new int[count];

                for (int i = 0; i < chars.Length; i++)
                {
                    nums[i] = ConvertStringPriority(chars[i]);
                }
                elfCluster[groupCounter] += (line.ToString() + '\n');

                if (groupTicker > 2) { Day3BCalc(elfCluster[groupCounter]); ; groupTicker = 0; groupCounter++; }
                groupTicker++;

                for (int i = 0; i < count / 2; i++)
                {
                    BagA[i] = nums[i];
                }

                for (int i = count / 2; i < count; i++)
                {
                    BagB[i - BagB.Length] = nums[i];
                }

                // 3A Calc
                for (int i = 0; i < BagA.Length; i++)
                {
                    for (int j = 0; j < BagB.Length; j++)
                    {
                        if (BagA[i] == BagB[j])
                        {
                            score += BagA[i];
                            counter++;

                            i = BagA.Length;

                            break;
                        }
                    }
                }
            }
            Console.WriteLine("\n\nDay 3A Calc: " + score);
            Console.WriteLine("Day 3B Calc: " + totalScoreB);
        }
        public void Day3BCalc(string str)
        {
            string[] elfs = str.Split('\n');
            Array.Sort(elfs, (y, x) => x.Length.CompareTo(y.Length));

            foreach (char c in elfs[0])
            {
                for (int i = 0; i < elfs[1].Length; i++)
                {
                    if (c == elfs[1][i])
                    {
                        for (int j = 0; j < elfs[2].Length; j++)
                        {
                            if (c == elfs[2][j])
                            {
                                totalScoreB += ConvertStringPriority(c);
                                return;
                            }
                        }
                    }
                }
            }
        }

        public int ConvertStringPriority(char input)
        {
            int number = 0;

            switch (input)
            {
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3;
                case 'd':
                    return 4;
                case 'e':
                    return 5;
                case 'f':
                    return 6;
                case 'g':
                    return 7;
                case 'h':
                    return 8;
                case 'i':
                    return 9;
                case 'j':
                    return 10;
                case 'k':
                    return 11;
                case 'l':
                    return 12;
                case 'm':
                    return 13;
                case 'n':
                    return 14;
                case 'o':
                    return 15;
                case 'p':
                    return 16;
                case 'q':
                    return 17;
                case 'r':
                    return 18;
                case 's':
                    return 19;
                case 't':
                    return 20;
                case 'u':
                    return 21;
                case 'v':
                    return 22;
                case 'w':
                    return 23;
                case 'x':
                    return 24;
                case 'y':
                    return 25;
                case 'z':
                    return 26;
                case 'A':
                    return 27;
                case 'B':
                    return 28;
                case 'C':
                    return 29;
                case 'D':
                    return 30;
                case 'E':
                    return 31;
                case 'F':
                    return 32;
                case 'G':
                    return 33;
                case 'H':
                    return 34;
                case 'I':
                    return 35;
                case 'J':
                    return 36;
                case 'K':
                    return 37;
                case 'L':
                    return 38;
                case 'M':
                    return 39;
                case 'N':
                    return 40;
                case 'O':
                    return 41;
                case 'P':
                    return 42;
                case 'Q':
                    return 43;
                case 'R':
                    return 44;
                case 'S':
                    return 45;
                case 'T':
                    return 46;
                case 'U':
                    return 47;
                case 'V':
                    return 48;
                case 'W':
                    return 49;
                case 'X':
                    return 50;
                case 'Y':
                    return 51;
                case 'Z':
                    return 52;
            }
            return number;
        }
    }
}