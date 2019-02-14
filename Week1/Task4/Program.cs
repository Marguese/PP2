using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()); /// giving a range
            string[,] arr = new string[a, a]; // creating 2d array
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < i + 1; j++) // j-th going by i-th
                {
                    arr[i, j] = "[*]"; // star

                    Console.Write(arr[i, j]); // line
                }
                Console.WriteLine(); // ending an line
            }
        }
    }
}
