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
            string s = Console.ReadLine(); // reading string 
            int a = int.Parse(s); // we converted to int
            string d = Console.ReadLine(); // creating sequence of numbers
            string[] num = d.Split(); // creating array and spliting numbers by space

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " " + num[i] + " "); // just duplicate that numbers
            }
        }
    }
}
