using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s);
            string d = Console.ReadLine();
            string[] num = d.Split(); // till this is creating an array
            List<int> primes = new List<int>(); // creating a vector to add the primes
            for (int i = 0; i < num.Length; i++)
            {
                if (Convert.ToInt32(num[i]) == 1) // firstly if array has 1, immediately break
                {
                    continue;
                }
                else if (Convert.ToInt32(num[i]) == 2 || Convert.ToInt32(num[i]) == 3) // if array has 2 or 3, adding to vector
                {
                    primes.Add(Convert.ToInt32(num[i])); // adding to vector
                    // Console.Write(num[i] + " ");
                    continue;
                }
                for (int k = 2; k <= Convert.ToInt32(num[i]); k++) // cycle for finding primes
                {
                    if (Convert.ToInt32(num[i]) % k == 0 && Convert.ToInt32(num[i]) != k) // if number has divisors and number isnt equal to itself, break
                    {
                        break;
                    }
                    else if (Convert.ToInt32(num[i]) == k) // if cycle going to the end and still there is no divisor, add the number
                    {
                        primes.Add(Convert.ToInt32(num[i])); // add to vector
                        // Console.Write(Convert.ToInt32(num[i]) + " ");
                    }
                }
            }
            int c = primes.Count; // length of vector or how many primes in vector
            Console.WriteLine(c); // output how many primes
            foreach (int g in primes) // output for primes
            {
                Console.Write(g + " "); // end :)
            }
        }
    }
}
