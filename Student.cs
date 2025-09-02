using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherretance1
{
    internal abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student() { 
        Id = 0;
        Name = "";
        GPA = 0;
        }
        public Student(int id, string name, double gpa)
        {
            Id = id;
            Name = name;
            GPA = gpa;
        }
        public Student(int id , string name):this(id,name,0) 
        {

        }
        public abstract double calcgpa(int bonus);
       

    }
}
