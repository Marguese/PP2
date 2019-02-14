using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise1
{
    class Program
    {
        public static void Palindrome(string pal)
        {
            char[] str = new char[pal.Length]; // dividing string
            bool ok = true; // boolean for palindrome or not
            for (int i = 0; i < str.Length; i++) // array of chars
            {
                str[i] = pal[i]; // putting chars to char array
            }
            for (int i = 0; i < str.Length; i++) // array of chars
            {
                if (str[i] == str[str.Length - i - 1]) // if first equal to last and so forth ...
                {
                    ok = true; // that is true.
                    continue;
                } else // if even one of them are not equal, so not ...
                {
                    ok = false; // false
                    break;
                }
            }
            if (ok) // if palindrome
            {
                Console.WriteLine("Yeah, that is palindrome!");
            } else // if not
            {
                Console.WriteLine("Sorry, it is not.");
            }
        }
        static void Main(string[] args)
        {
            string pal = Console.ReadLine(); //string
            Palindrome(pal); // calling func
        }
    }
}
