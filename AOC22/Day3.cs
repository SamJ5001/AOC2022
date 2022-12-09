using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace AOC22
{

    class Badge
    {
        public int ID;
        public int Number;
   
    }

    class Day3
    {
        private InputReader inputReader;

        public Badge[] badgeArray;
        private bool createFirstTime = true;

        public void Day3Calc()
        {
            inputReader = new InputReader();

            Badge[] badgeArray = new Badge[inputReader.LineCount("Input3.txt")];

            for (int i = 0; i < badgeArray.Length; i++)
            {
                badgeArray[i] = new Badge();
                badgeArray[i].ID = i;
            }

            int score = 0;

            string actualPath = inputReader.GetActualPath("Input3.txt");
            foreach (string line in File.ReadLines(actualPath))
            {
                var counter = 0;

                int count = line.Length;

                int[] BagA = new int[count / 2];
                int[] BagB = new int[count / 2];

                char[] chars = line.ToCharArray();
                int[] nums = new int[count];


                for (int i = 0; i < chars.Length; i++)
                {
                    nums[i] = ConvertStringPriority(chars[i]);
                }

                for (int i = 0; i < count / 2; i++)
                {
                    BagA[i] = nums[i];
                }

                for (int i = count / 2; i < count; i++)
                {
                    BagB[i - BagB.Length] = nums[i];
                }

                for (int i = 0; i < BagA.Length; i++)
                {
                    for (int j = 0; j < BagB.Length; j++)
                    {
                        if (BagA[i] == BagB[j])
                        {
                            Console.WriteLine(line);
                            Console.WriteLine("Bag A:" + BagA[i]);
                            Console.WriteLine("Bag B:" + BagB[j]);
                            score += BagA[i];

                            badgeArray[i].Number = BagA[i];

                            counter++;
                            i = BagA.Length;

                            break;
                        }
                    }
                }

            }
            Console.WriteLine("Day 3 Score: " + score);
            GroupBadges();

        }

        public void GroupBadges()
        {
            for (int i = 0; i < badgeArray.Length; i++)
            {
                for (int j = 0; j < badgeArray.Length; j++)
                {
                    if (i != j && badgeArray[i].ID == badgeArray[j].ID)
                    {
                        // I'm sweeping and comparing integers.


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