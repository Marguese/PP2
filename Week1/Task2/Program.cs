using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // creating an function
    {
        public string name; // name
        public string id; // id
        public int yearofs; // year of study

        public Student(string a, string b, int c) // for the first info
        {
            name = a;
            id = b;
            yearofs = c;
        }
        public Student(string name, string id) // that is without year of st.
        {
            this.name = name;
            this.id = id;
        }
        public void Print() // function that calling name, id, year.
        {
            Console.WriteLine(name + " " + id + " " + yearofs);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Margellan", "18BD110186", 1); // creating student
            st.Print(); // output that infos
            Student stu = new Student("Margellan", "18BD110186"); // there is without increment of year.
            stu.yearofs = st.yearofs + 1; // increment is here!
            stu.Print(); // calling with increment
        }
    }
}

