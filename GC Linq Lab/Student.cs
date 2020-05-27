using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Linq_Lab
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }

        public Student(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
    }
}
