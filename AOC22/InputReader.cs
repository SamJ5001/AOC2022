using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AOC22
{
    class InputReader
    {

        // Reads the raw data input from teh string and appends to a single list
        public List<string> ReadInputString(string path, bool allowEmptyRows)
        {

            List<string> inputString = new List<string>();

            int lineCounter = 0;

            foreach (string line in File.ReadLines(path))
            {
                lineCounter++;
                if (line != "" || allowEmptyRows)
                {
                    inputString.Add(line);
                }
            }

            return inputString;
        }




        // Reads the raw data input and groups according to the spaces
        public List<int> ReadInputGroups(string path)
        {
            List<int> inputGroups = new List<int>();
            var groupCount = 0;

            foreach (string line in File.ReadLines(path))
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
