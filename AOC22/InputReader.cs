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
        /*
            using (StreamReader sr = new StreamReader(path))
            {
                
                String line;
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            
                            
                        }
                        
                    }
                }

                return inputString;
            }
        */


    }
}
