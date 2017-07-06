using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Censorship
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string word2 = ""; 
            for (int i = 0; i < word.Length; i++)
            {
                word2 += '*';
            }
            string sentence = Console.ReadLine();
            string matches = Regex.Replace(sentence, word, word2);            
            Console.WriteLine(matches);
        }
    }
}
