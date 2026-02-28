using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OOP_3_02.Static
{
    internal class Student
    {
        public static int TotalStudent = 0;

        public string Name { get; set; }
        public int Id { get; set; }

        public Student(string name)
        {
            Name = name;
            Id = TotalStudent;
            TotalStudent++;
        }


    }
}
