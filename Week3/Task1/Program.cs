using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Parts
    {
        static int currentCursor;
        public int CurrentCursor
        {
            get
            {
                return currentCursor;
            }
            set
            {
                if (value <= fs.Count)
                {
                    currentCursor = 0;
                }
                else if (value < 0)
                {
                    currentCursor = fs.Count - 1;
                }
                else
                {
                    currentCursor = value;
                }
            }
        }
        public List<FileSystemInfo> fs
        {
            get;
            set;
        }
        public void Interface()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 0; i < fs.Count; ++i)
            {
                Console.WriteLine(fs[i].Name);
                if (i == CurrentCursor)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(fs[i].Name);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Parts par = new Parts();
                string path = "C:/Users/Le Marguese/source/repos";
                DirectoryInfo dir = new DirectoryInfo(path);
                List<Parts> p = new List<Parts>();
                p.Add(par); {
                    par.fs = dir.GetFileSystemInfos().ToList();
                    par.CurrentCursor = 0;
                };
                if (par.fs.GetType() == typeof(DirectoryInfo))
                    {
                        foreach (FileSystemInfo fes in par.fs)
                        {
                            par.Interface();
                        }
                    }
                }
            }
        }
    }
