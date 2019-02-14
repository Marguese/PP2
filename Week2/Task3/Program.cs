using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task2
{
    class Program
    {
        public static void Level(int l)
        {
            for (int i = 0; i < l; i++)
            {
                Console.Write(" "); // empty ladder
            }
        }
        public static void Show(string path, int le)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileSystemInfo[] fileSystemInfos = directory.GetFileSystemInfos();
            foreach (FileSystemInfo fs in fileSystemInfos)
            {
                if (fs.GetType() == typeof(DirectoryInfo))
                {
                    if (fs.Name.StartsWith(".")) // for hidden directors
                    {
                        continue;
                    }
                    else // not hidden
                    {
                        Level(le); // empty place
                        Console.WriteLine(fs.Name); // name of dir
                        Show(path + "/" + fs.Name, le + 1); //Users/Le Marguese/source/repos/...
                    }
                }
                else // if file
                {
                    if (fs.Name.StartsWith(".")) // hidden
                    {
                        continue;
                    }
                    else // not
                    {
                        Level(le); // empty space
                        Console.WriteLine(fs.Name); // name of file
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            string path = "C:/Users/Le Marguese/source"; // path
            Show(path, 0); // calling func
        }
    }
}