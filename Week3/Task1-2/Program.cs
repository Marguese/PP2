using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Task1_2
{
    class Parts // creating class
    {
        private int selectedItem; // current cursor
        public int SelectedItem
        {
            get
            {
                return selectedItem; 
            }
            set
            {
                if (value >= Content.Count) // if cursor goes below length
                {
                    selectedItem = 0;
                }
                else if (value < 0) // if cursor goes above length
                {
                    selectedItem = Content.Count - 1;
                }
                else // or cursor equal to currentDirectory place
                {
                    selectedItem = value;
                }
            }
        }

        public List<FileSystemInfo> Content // create vector for files
        {
            get; // giving operator
            set;
        }

        public void DeleteSelectedItem() // delete file
        {
            FileSystemInfo fileSystemInfo = Content[selectedItem]; // current directory
            if (fileSystemInfo.GetType() == typeof(DirectoryInfo)) // if directory
            {
                Directory.Delete(fileSystemInfo.FullName, true); // delete yes
            }
            else // or
            {
                File.Delete(fileSystemInfo.FullName); // delete file
            }
            Content.RemoveAt(selectedItem); // decreasing size of vector
            selectedItem--; // decrement
        }

        public void Draw()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < Content.Count; ++i)
            {
                if (i == SelectedItem) // current Directory or File is blue
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else // where is not cursor, black
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(Content[i].Name); // write

            }
        }
        enum Type // creating type, file dir
        {
            File,
            Directory
        }
        class Program
        {
            static void Main(string[] args)
            {
                Type typ = Type.Directory; // firstly directory
                string path = "C:/Users/Le Marguese/Desktop";
                DirectoryInfo dir = new DirectoryInfo(path);
                Stack<Parts> par = new Stack<Parts>(); // putting all of that in stack LIFO
                par.Push(
                    new Parts
                    {
                        Content = dir.GetFileSystemInfos().ToList(), // every file goes to List
                        SelectedItem = 0
                    });
                while (true)
                {
                    par.Peek().Draw(); // Drawing Interface
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(); // for keys
                    switch (consoleKeyInfo.Key)
                    {
                        case ConsoleKey.F2: // if F2, then Rename that by giving own name
                            int y = par.Peek().SelectedItem;
                            FileSystemInfo fos = par.Peek().Content[y];
                            string chan = Console.ReadLine();
                            DirectoryInfo df = new DirectoryInfo(fos.FullName);
                            File.Move(fos.FullName, df.Parent.FullName + "/" + chan);
                            break;
                        case ConsoleKey.Delete: // if Delete, then Delete
                            par.Peek().DeleteSelectedItem();
                            break;
                        case ConsoleKey.UpArrow: // goes up
                            par.Peek().SelectedItem--;
                            break;
                        case ConsoleKey.DownArrow: // goes down
                            par.Peek().SelectedItem++;
                            break;
                        case ConsoleKey.Backspace: // previous direction
                            if (typ == Type.Directory)
                            {
                                par.Pop();
                            } else
                            {
                                typ = Type.Directory;
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            break;
                        case ConsoleKey.Enter: // entering to dir, if file - open
                            int x = par.Peek().SelectedItem;
                            FileSystemInfo fileSystemInfo = par.Peek().Content[x];
                            if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                            {
                                DirectoryInfo directoryInfo = fileSystemInfo as DirectoryInfo;
                                par.Push(
                                   new Parts
                                   {
                                       Content = directoryInfo.GetFileSystemInfos().ToList(),
                                       SelectedItem = 0
                                   });
                            }
                            else
                            {
                                Process.Start(fileSystemInfo.FullName);
                            }
                            break;
                    }
                }
            }
        }
    }
}
