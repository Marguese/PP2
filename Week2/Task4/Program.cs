using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        public static void Place(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path); // dir
            string pat = directory.Parent.FullName; // previous dir
            using (FileStream fs = File.Create(path + "/KBTU.txt")) // because of "Файл используется другим процессом" I created Stream that Close automatically
            {
            }
            File.Copy(path + "/KBTU.txt", pat + "/KBTU.txt"); // creating KBTU.txt and copying new file KBTU.txt to previous dir
        }
        static void Main(string[] args) 
        {
            string path = "C:/Users/Le Marguese/Desktop/Dada/qwewq"; // dir
            Place(path);  // calling with dir
            File.Delete(path + "/KBTU.txt"); // deleting original one
        }
    }
}
