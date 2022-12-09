using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace AOC22
{
    class InputReader
    {
        public string GetActualPath(string path)
        {
            string fullPath = StartAOC.InputBin.ToString() + path;
            return fullPath;
        }

        // Reads the raw data input from the string and appends to a single list
        public List<string> ReadInputString(string path, bool allowEmptyRows)
        {
            string actualPath = GetActualPath(path);
            List<string> inputString = new List<string>();

            int lineCounter = 0;

            foreach (string line in File.ReadLines(actualPath))
            {
                lineCounter++;
                if (line != "" || allowEmptyRows)
                {
                    inputString.Add(line);
                }
            }
            return inputString;
        }


        // Reads the input and returns the number of lines. Nothing more, nothing less.
        private string[] opp;
        private string[] player;
        public int RPSSetup(string path)
        {
            opp = new string[LineCount(path)];
            player = new string[LineCount(path)];

            string actualPath = GetActualPath(path);
            int lineCount = 0;
            foreach (string line in File.ReadLines(actualPath))
            {
                
                char[] chars = line.ToCharArray();

                    opp[lineCount] = chars[0].ToString();
                    player[lineCount] = chars[2].ToString();
                lineCount++;
            }
            return lineCount;
        }

        public int RPSScore2A(int round)
        {
            int winScore = 0;
            int shapeScore = 0;

            switch (player[round])
            {
                case "X": // Rock
                    if (opp[round] == "A") { winScore = 3; } // R
                    else if (opp[round] == "B") { winScore = 0; } // P
                    else if (opp[round] == "C") { winScore = 6; } // S
                    shapeScore = 1;
                    break;

                case "Y": // Paper
                    if (opp[round] == "A") { winScore = 6; } // R
                    else if (opp[round] == "B") { winScore = 3; } // P
                    else if (opp[round] == "C") { winScore = 0; } // S
                    shapeScore = 2;
                    break;

                case "Z": // Scissors
                    if (opp[round] == "A") { winScore = 0; } // R
                    else if (opp[round] == "B") { winScore = 6; } // P
                    else if (opp[round] == "C") { winScore = 3; } // S
                    shapeScore = 3;
                    break;
            }
            return winScore + shapeScore;
        }

        public int RPSScore2B(int round)
        {
            int winScore = 0;
            int shapeScore = 0;

            switch (player[round])
            {
                case "X": // Lose
                    if (opp[round] == "A") { shapeScore = 3; } // R
                    else if (opp[round] == "B") { shapeScore = 1; } // P
                    else if (opp[round] == "C") { shapeScore = 2; } // S
                    winScore = 0;
                    break;

                case "Y": // Draw
                    if (opp[round] == "A") { shapeScore = 1; } // R
                    else if (opp[round] == "B") { shapeScore = 2; } // P
                    else if (opp[round] == "C") { shapeScore = 3; } // S
                    winScore = 3;
                    break;

                case "Z": // Win
                    if (opp[round] == "A") { shapeScore = 2; } // R
                    else if (opp[round] == "B") { shapeScore = 3; } // P
                    else if (opp[round] == "C") { shapeScore = 1; } // S
                    winScore = 6;
                    break;
            }
            return winScore + shapeScore;
        }



        public int LineCount(string path)
        {
            string actualPath = GetActualPath(path);
            int lineCount = 0;
            foreach (string line in File.ReadLines(actualPath))
            {
                lineCount++;
            }
            return lineCount;
        }

        // Reads the raw data input and groups according to the spaces
        public List<int> ReadInputGroups(string path)
        {
            string actualPath = GetActualPath(path);
            List<int> inputGroups = new List<int>();
            var groupCount = 0;

            foreach (string line in File.ReadLines(actualPath))
            {
                if (line == "")
                {
                    inputGroups.Add(groupCount);
                    groupCount = 0;
                }
                else
                {
                    groupCount += int.Parse(line);
                }
            }
            return inputGroups;
        }





    }
}