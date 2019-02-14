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
        static List<int> primes = new List<int>(); // for primes
        static string[] str; //
        static void Give(string path)
        {
            using (StreamReader sr = new StreamReader(path)) // read from file
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    str = line.Split(); // splitting a file and putting in array of string
                }
                sr.Close(); // close
            }
        }

        static void Main(string[] args)
        {
            string path = "input.txt"; // the file
            Give(path); // giving string
            for (int i = 0; i < str.Length; i++)
            {
                if (int.Parse(str[i]) == 1) // firstly if array has 1, immediately break
                {
                    continue;
                }
                else if (int.Parse(str[i]) == 2 || int.Parse(str[i]) == 3) // if array has 2 or 3, adding to vector
                {
                    primes.Add(int.Parse(str[i])); // adding to vector
                    // Console.Write(num[i] + " ");
                    continue;
                }
                for (int k = 2; k <= int.Parse(str[i]); k++) // cycle for finding primes
                {
                    if (int.Parse(str[i]) % k == 0 && int.Parse(str[i]) != k) // if number has divisors and number isnt equal to itself, break
                    {
                        break;
                    }
                    else if (int.Parse(str[i]) == k)  // if cycle going to the end and still there is no divisor, add the number
                    {
                        primes.Add(int.Parse(str[i]));
                        break;
                        // Console.Write(Convert.ToInt32(num[i]) + " ");
                    }
                }
            }
            StreamWriter sw = new StreamWriter("output.txt"); // output to file
            foreach (int w in primes)
            {
                sw.Write(w + " "); // putting primes
            }
            sw.Close(); // close
        }
    }
}
