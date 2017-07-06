using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine().Split('@').ToList();
            var name = email[0];
            var domain = email[1];
            int sumLeft = 0;
            int sumRight = 0;

            foreach (char letter in name)
            {
                sumLeft += (int)letter;
            }
            foreach (char letter in domain)
            {
                sumRight += (int)letter;
            }
            if (sumLeft>=sumRight)
            {
                Console.WriteLine("Call her!");
            }
            else Console.WriteLine("She is not the one.");
        }
    }
}
