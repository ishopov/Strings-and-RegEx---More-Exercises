﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"(?<digits>\d+)(?<ch>[A-Za-z])";
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                text = text.Replace(
                    match.Groups["digits"].Value, match.Groups["ch"].Value);
            }

            Console.WriteLine(text);

        }
    }
}
