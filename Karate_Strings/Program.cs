﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var outputString = string.Empty;
            var punchStrength = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '>')
                {
                    punchStrength += int.Parse(inputString[i + 1].ToString());
                }
                else if (punchStrength > 0)
                {
                    punchStrength--;
                    continue;
                }
                outputString += inputString[i];
            }

            Console.WriteLine(outputString);
        }
    }
}
