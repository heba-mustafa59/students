 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherretance1
{
    internal class CsStudent: Student
    {
        public string desc {  get; set; }
        public int level { get; set; }

        public CsStudent(int id,string name, double gpa
            ,string descc,int lev):base(id, name, 
                gpa)
        {
           desc = descc;
            level = lev;
        }

        public override double calcgpa(int bonus)
        {
            return GPA + bonus; 
              
        }
    }
}
